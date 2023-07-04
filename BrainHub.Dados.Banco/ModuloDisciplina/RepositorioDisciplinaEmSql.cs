
using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioSqlBase<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        protected override string sqlInserir => @"INSERT INTO [TBDisciplina] ( [NOME] ) VALUES ( @NOME );  SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [TBDisciplina] 
													SET 
														[NOME] = @NOME,
													WHERE 
														[ID] = @ID";

        protected override string sqlExcluir => @"DELETE FROM [TBDisciplina]
	                                                    WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        [id] AS DISCIPLINA_ID,
	                                                        [NOME] AS DISCIPLINA_ID
	                                                    FROM [TBDisciplina];";

        protected override string sqlSelecionarPorId => @"SELECT 
															[ID]   AS  DISCIPLINA_ID 
														   ,[NOME] AS  DISCIPLINA_ID
														FROM 
															[TBDisciplina] 
														WHERE 
															[ID] = @ID";

        private const string sqlSelecionarMateria = @"SELECT 
		                                            M.[ID] AS MATERIA_ID,
		                                            M.[NOME] AS MATERIA_NOME			
	                                            FROM TBMateria AS M 
	                                            WHERE M.disciplina_id = @DISCIPLINA_ID;";

        public override Disciplina SelecionarPorId(int id)
        {
            Disciplina disciplina = base.SelecionarPorId(id);

            if (disciplina != null)
                CarregarMaterias(disciplina);

            return disciplina;
        }

        private void CarregarMaterias(Disciplina disciplina)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarMaterias= conexaoComBanco.CreateCommand();
            comandoSelecionarMaterias.CommandText = sqlSelecionarMateria;

            comandoSelecionarMaterias.Parameters.AddWithValue("DISCIPLINA_ID", disciplina.id);

            SqlDataReader leitorAluguel = comandoSelecionarMaterias.ExecuteReader();

            MapeadorMateria mapeador = new MapeadorMateria();

            while (leitorAluguel.Read())
            {
                Materia materia = mapeador.ConverterRegistro(leitorAluguel);

                disciplina.AdicionarMateria(materia);
            }

            conexaoComBanco.Close();

        }
    }
}
