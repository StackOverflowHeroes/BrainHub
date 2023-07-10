
using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dados.Banco.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioSqlBase<Materia, MapeadorMateria>, IRepositorioMateria
    {
        protected override string sqlInserir => @"INSERT INTO [TBMateria] ( [NOME], [SERIE], [DISCIPLINA_ID] ) VALUES (@NOME, @SERIE, @DISCIPLINA_ID);  SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE TBMateria SET 
                                                                [NOME] = @NOME, 
                                                                [serie] = @SERIE, 
                                                                [DISCIPLINA_ID] = @DISCIPLINA_ID 
                                                                WHERE [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM TBMateria WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
																M.[id] AS MATERIA_ID,
																M.[nome] AS MATERIA_NOME,
																M.[serie] AS MATERIA_SERIE,
																D.id AS DISCIPLINA_ID,
																D.nome AS DISCIPLINA_NOME
															FROM 
															[TBMateria] AS M INNER JOIN [TBDisciplina] AS D 
															ON M.disciplina_id = D.id";

        protected override string sqlSelecionarPorId => @"SELECT 
	                                                            M.[id] AS MATERIA_ID,
	                                                            M.[nome] AS MATERIA_NOME,
	                                                            M.[serie] AS MATERIA_SERIE,
	                                                            D.id AS DISCIPLINA_ID,
	                                                            D.nome AS DISCIPLINA_NOME
	                                                        FROM 
	                                                            [TBMateria] AS M INNER JOIN [TBDisciplina] AS D 
	                                                            ON M.disciplina_id = D.id
	                                                        WHERE M.id = @ID;";

        protected string sqlSelecionarQuestoesMateria => @"SELECT 
	                                                        Q.ID AS QUESTAO_ID,  
	                                                        Q.ENUNCIADO AS QUESTAO_ENUNCIADO,  
	                                                        Q.MATERIA_ID AS MATERIA_ID,  
	                                                        Q.RESPOSTA AS QUESTAO_RESPOSTA, 
	                                                        M.NOME AS MATERIA_NOME,  
                                                            M.SERIE AS MATERIA_SERIE,
                                                            M.DISCIPLINA_ID AS DISCIPLINA_ID

                                                        FROM 
	                                                        TBQuestao AS Q INNER JOIN TBMateria AS M
	                                                        ON Q.materia_id = M.id
                                                        WHERE Q.materia_id = @ID";

        public override Materia SelecionarPorId(int id)
        {
            Materia materia = base.SelecionarPorId(id);

            if (materia != null)
                CarregarQuestoes(materia);

            return materia;
        }

        private void CarregarQuestoes(Materia materia)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarMaterias = conexaoComBanco.CreateCommand();
            comandoSelecionarMaterias.CommandText = sqlSelecionarQuestoesMateria;

            comandoSelecionarMaterias.Parameters.AddWithValue("ID", materia.id);

            SqlDataReader leitorMateria = comandoSelecionarMaterias.ExecuteReader();

            while (leitorMateria.Read())
            {
                Questao questao = ConverterParaQuestao(materia, leitorMateria);

                materia.AdicionarQuestoes(questao);
            }

            conexaoComBanco.Close();
        }

        private Questao ConverterParaQuestao(Materia materia, SqlDataReader leitorMateria)
        {
            int id = Convert.ToInt32(leitorMateria["QUESTAO_ID"]);
            string enunciado = Convert.ToString(leitorMateria["QUESTAO_ENUNCIADO"])!;
            string resposta = Convert.ToString(leitorMateria["QUESTAO_RESPOSTA"])!;

            return new Questao(id, enunciado, resposta, materia);
        }

        public override List<Materia> SelecionarTodos(bool CarregarDependencias = false)
        {
            List<Materia> materias = base.SelecionarTodos();

            foreach (Materia materia in materias)
            {
                if (CarregarDependencias)
                    CarregarQuestoes(materia);
            }

            return materias;

        }
    }
}
