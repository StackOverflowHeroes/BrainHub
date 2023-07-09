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

          private string sqlInserirAlternativa =>

               @"INSERT INTO [TBAlternativa] 
               ( 
                         QUESTAO_ID, 
                         TITULO, 
                         LETRA,
                         CORRETA
               ) 
                    VALUES 
               (
                         @QUESTAO_ID, 
                         @TITULO, 
                         @LETRA,
                         @CORRETA
               )";

          private string sqlExcluirAlternativa =>

               @"DELETE FROM [TBAlternativa] 

               WHERE 
                    QUESTAO_ID = @QUESTAO_ID";

          private string sqlSelecionarAlternativas =>

               @"SELECT
                          A.ID AS ALTERNATIVA_ID,  
                          A.TITULO AS ALTERNATIVA_TITULO,  
                          A.LETRA AS ALTERNATIVA_LETRA, 
                          A.CORRETA AS ALTERNATIVA_CORRETA, 
                          A.QUESTAO_ID AS QUESTAO_ID,  

                          Q.ENUNCIADO AS QUESTAO_ENUNCIADO,  
                          Q.RESPOSTA AS QUESTAO_RESPOSTA,
                          Q.MATERIA_ID AS MATERIA_ID,  

                          M.NOME AS MATERIA_NOME,  
                          M.SERIE AS MATERIA_SERIE,
                          M.DISCIPLINA_ID AS DISCIPLINA_ID, 

                          D.NOME AS DISCIPLINA_NOME

                     FROM
                          [TBAlternativa] AS A

                               INNER JOIN [TBQuestao] AS Q
                               ON Q.ID = A.QUESTAO_ID

                               INNER JOIN [TBMateria] AS M
                               ON Q.MATERIA_ID = M.ID

                               INNER JOIN [TBDisciplina] AS D
                               ON M.DISCIPLINA_ID = D.ID

               WHERE

                    A.QUESTAO_ID    = @QUESTAO_ID AND
                    Q.MATERIA_ID    = @MATERIA_ID AND
                    M.DISCIPLINA_ID = @DISCICPLINA_ID";

     }
}
