using BrainHub.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloQuestao
{
     public class RepositorioQuestaoEmSql : RepositorioSqlBase<Questao, MapeadorQuestao>
     {
          protected override string sqlInserir => 
               
               @"INSERT INTO [TBQuestao] 
               ( 
                         ENUNCIADO, 
                         MATERIA_ID, 
                         RESPOSTA
               ) 
                    VALUES 
               (
                         @ENUNCIADO, 
                         @MATERIA_ID, 
                         @RESPOSTA
               )  
               SELECT SCOPE_IDENTITY()";

          protected override string sqlEditar =>

               @"UPDATE [TBQuestao] 
                    SET 

               ENUNCIADO =  @ENUNCIADO, 
               MATERIA_ID = @MATERIA_ID, 
               RESPOSTA =   @RESPOSTA

               WHERE 
                    ID = @ID";

          protected override string sqlExcluir =>

               @"DELETE FROM [TBQuestao]

	          WHERE 
		          ID = @ID";

          protected override string sqlSelecionarTodos =>

               @"SELECT
                         Q.ID AS QUESTAO_ID,  
                         Q.ENUNCIADO AS QUESTAO_ENUNCIADO,  
                         Q.MATERIA_ID AS MATERIA_ID,  
                         Q.RESPOSTA AS QUESTAO_RESPOSTA, 

                         M.NOME AS MATERIA_NOME,  
                         M.SERIE AS MATERIA_SERIE,
                         M.DISCIPLINA_ID AS DISCIPLINA_ID,  

                         D.NOME AS DISCIPLINA_NOME

                    FROM
                         [TBQuestao] AS Q

                              INNER JOIN [TBMateria] AS M
                              ON Q.MATERIA_ID = M.ID

                              INNER JOIN [TBDisciplina] AS D
                              ON M.DISCIPLINA_ID = D.ID";

          protected override string sqlSelecionarPorId =>

               @"SELECT
                         Q.ID AS QUESTAO_ID,  
                         Q.ENUNCIADO AS QUESTAO_ENUNCIADO,  
                         Q.MATERIA_ID AS MATERIA_ID,  
                         Q.RESPOSTA AS QUESTAO_RESPOSTA, 

                         M.NOME AS MATERIA_NOME,  
                         M.SERIE AS MATERIA_SERIE,
                         M.DISCIPLINA_ID AS DISCIPLINA_ID,  

                         D.NOME AS DISCIPLINA_NOME

                    FROM
                         [TBQuestao] AS Q

                              INNER JOIN [TBMateria] AS M
                              ON Q.MATERIA_ID = M.ID

                              INNER JOIN [TBDisciplina] AS D
                              ON M.DISCIPLINA_ID = D.ID
               WHERE
                    Q.ID = @ID";
     }
}
