
using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioSqlBase<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        protected override string sqlInserir => @"INSERT INTO [TBDisciplina] ( [NOME] ) VALUES ( @NOME );  SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [TBDisciplina] 
													SET 
														[NOME] = @NOME
													WHERE 
														[ID] = @ID";

        protected override string sqlExcluir => @"DELETE FROM [TBDisciplina]
	                                                    WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        [id] AS DISCIPLINA_ID,
	                                                        [NOME] AS DISCIPLINA_NOME
	                                                    FROM [TBDisciplina];";

        protected override string sqlSelecionarPorId => @"SELECT 
															[ID]   AS  DISCIPLINA_ID 
														   ,[NOME] AS  DISCIPLINA_NOME
														FROM 
															[TBDisciplina] 
														WHERE 
															[ID] = @ID";

        private const string sqlSelecionarMateria = @"SELECT 
		                                            M.[ID] AS MATERIA_ID,
		                                            M.[NOME] AS MATERIA_NOME,
                                                    M.[SERIE] AS MATERIA_SERIE
	                                            FROM TBMateria AS M 
	                                            WHERE M.disciplina_id = @DISCIPLINA_ID;";

        public override Disciplina SelecionarPorId(int id)
        {
            Disciplina disciplina = base.SelecionarPorId(id);

            if (disciplina != null)
                CarregarMaterias(disciplina);

            return disciplina;
        }

        public override List<Disciplina> SelecionarTodos(bool carregarDependencias = false)
        {
            List<Disciplina> disciplinas = base.SelecionarTodos();

            foreach (Disciplina disciplina in disciplinas)
            {
                if (carregarDependencias)
                    CarregarMaterias(disciplina);
            }

            return disciplinas;

        }

        private void CarregarMaterias(Disciplina disciplina)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarMaterias = conexaoComBanco.CreateCommand();
            comandoSelecionarMaterias.CommandText = sqlSelecionarMateria;

            comandoSelecionarMaterias.Parameters.AddWithValue("DISCIPLINA_ID", disciplina.id);

            SqlDataReader leitorMateria = comandoSelecionarMaterias.ExecuteReader();

            while (leitorMateria.Read())
            {
                Materia materia = ConverterParaMateria(disciplina, leitorMateria);

                disciplina.AdicionarMateria(materia);
            }

            conexaoComBanco.Close();

        }

        private Materia ConverterParaMateria(Disciplina disciplina, SqlDataReader leitorMateria)
        {

            int id = Convert.ToInt32(leitorMateria["MATERIA_ID"]);
            string nome = Convert.ToString(leitorMateria["MATERIA_NOME"]);

            SerieEnum serie;

            if (Convert.ToInt32(leitorMateria["MATERIA_SERIE"]) == 1)
                serie = SerieEnum.primeiraSerie;
            else
                serie = SerieEnum.segundaSerie;


            return new Materia(id, nome, disciplina, serie);
        }

    }
}
