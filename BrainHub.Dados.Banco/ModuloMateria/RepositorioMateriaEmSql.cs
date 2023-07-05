
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioSqlBase<Materia, MapeadorMateria>, IRepositorioMateria
    {
        protected override string sqlInserir => @"INSERT INTO [TBMateria] ( [NOME], [SERIE], [DISCIPLINA] ) VALUES ('@NOME', '@SERIE', '@DISCIPLINA_ID');  SELECT SCOPE_IDENTITY();";

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
    }
}
