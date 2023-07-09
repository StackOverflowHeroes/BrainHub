using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloTeste
{
    internal class RepositorioTesteEmSql : RepositorioSqlBase<Teste, MapeadorTeste>, IRepositorioTeste
    {
        protected override string sqlInserir => @"INSERT INTO [TBTeste] ( [NOME]
                                                                         ,[NUMEROQUESTOES]
                                                                         ,[PROVARECUPERACAO]
                                                                         ,[SERIE]
                                                                         ,[DATA]
                                                                         ,[DISCIPLINA_ID]
                                                                         ,[MATERIA_ID] ) 
                                                                 VALUES ( @NOME
                                                                         ,@NUMERO_QUESTOES
                                                                         ,@PROVA_RECUPERACAO
                                                                         ,@SERIE
                                                                         ,@DATA
                                                                         ,@DISCIPLINA_ID
                                                                         ,@MATERIA_ID );
                                                                         SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [TBTESTE] 
                                                                SET
                                                                    [NOME] = @NOME
                                                                   ,[NUMEROQUESTOES] = @NUMERO_QUESTOES
                                                                   ,[PROVARECUPERACAO] = @PROVARECUPERACAO
                                                                   ,[DATA] = @DATA
                                                                   ,disciplina_id = @DISCIPLINA_ID
                                                                   ,materia_id = @MATERIA_ID
                                                                   ,[SERIE] = @SERIE
                                                                WHERE
                                                                   [ID] = @ID";

        protected override string sqlExcluir => @"DELETE FROM TBTeste WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT  T.[ID] AS TESTE_ID
                                                                 ,T.[NOME] AS TESTE_NOME
                                                                 ,T.[NUMEROQUESTOES] AS NUMERO_QUESTOES
                                                                 ,T.[PROVARECUPERACAO] AS PROVA_RECUPERACAO
                                                                 ,[DATA] AS TESTE_DATA

                                                                 ,D.id AS DISCIPLINA_ID
                                                                 ,D.nome AS DISCIPLINA_NOME

                                                                 ,M.id AS MATERIA_ID
                                                                 ,M.nome AS MATERIA_NOME
                                                                 ,M.serie AS MATERIA_SERIE
                                                                 ,M.[DISCIPLINA_ID] AS MATERIA_DISCIPLINA_ID

                                                           FROM [TBTESTE] AS T 
                                                                INNER JOIN TBDisciplina AS D ON T.disciplina_id = D.id
                                                                LEFT JOIN TBMateria AS M ON T.materia_id = M.id";

        protected override string sqlSelecionarPorId => @"SELECT T.[ID] AS TESTE_ID
                                                                 ,T.[NOME] AS TESTE_NOME
                                                                 ,T.[NUMEROQUESTOES] AS NUMERO_QUESTOES
                                                                 ,T.[PROVARECUPERACAO] AS PROVA_RECUPERACAO
                                                                 ,[DATA] AS TESTE_DATA

                                                                 ,D.id AS DISCIPLINA_ID
                                                                 ,D.nome AS DISCIPLINA_NOME

                                                                 ,M.id AS MATERIA_ID
                                                                 ,M.nome AS MATERIA_NOME
                                                                 ,M.serie AS MATERIA_SERIE
                                                                 ,M.[DISCIPLINA_ID] AS MATERIA_DISCIPLINA_ID
                                                          FROM [TBTESTE] AS T 
                                                                INNER JOIN TBDisciplina AS D ON T.disciplina_id = D.id
                                                                INNER JOIN TBMateria AS M ON T.materia_id = M.id
                                                          WHERE [ID] = @ID";

        protected string sqlInserirQuestoes => @"INSERT INTO [TBTESTE_TBQUESTAO]
                                                            (TESTE_ID]
                                                            ,[QUESTAO_ID])
                                                        VALUES
                                                            (@TESTE_ID
                                                            ,QUESTAO_ID)";
        protected string sqlSelecionarQuestoes => @"SELECT TQ.[TESTE_ID]
                                                           ,TQ.[QUESTAO_ID]
                                                           ,Q.[ID] AS QUESTAO_ID
                                                           ,Q.[MATERIA_ID] AS QUESTAO_MATERIA_ID
                                                           ,Q.[ENUNCIADO] AS QUESTAO_ENUNCIADO
                                                           ,Q.[ALTERNATIVACORRETA] AS QUESTAO_ALTERNATIVACORRETA
                                                           ,M.id AS MATERIA_ID
                                                           ,M.nome AS MATERIA_NOME
                                                           ,M.serie AS MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID] AS MATERIA_DISCIPLINA_ID
                                                           ,D.id AS DISCIPLINA_ID
                                                           ,D.nome AS DISCIPLINA_NOME
                                                    FROM TBTESTE_QUESTAO AS TQ
                                                         INNER JOIN [TBQUESTAO] AS Q ON TQ.[QUESTAO_ID] = Q.[ID]
                                                         INNER JOIN [TBMATERIA] AS M ON Q.[MATERIA_ID] = M.[ID]
                                                         INNER JOIN [TBDISCIPLINA] AS D ON M.[DISCIPLINA_ID] = D.[ID]
                                                    WHERE [TESTE_ID] = @ID";
        
    }
}
