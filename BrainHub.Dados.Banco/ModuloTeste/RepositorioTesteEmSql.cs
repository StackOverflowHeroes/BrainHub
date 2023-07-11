using BrainHub.Dados.Banco.ModuloQuestao;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BrainHub.Dados.Banco.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioSqlBase<Teste, MapeadorTeste>, IRepositorioTeste
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
                                                                         ,@PROVARECUPERACAO
                                                                         ,@SERIE
                                                                         ,@TESTE_DATA
                                                                         ,@DISCIPLINA_ID
                                                                         ,@MATERIA_ID );
                                                                         SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [TBTESTE] 
                                                                SET
                                                                    [NOME] = @NOME
                                                                   ,[NUMEROQUESTOES] = @NUMERO_QUESTOES
                                                                   ,[PROVARECUPERACAO] = @PROVARECUPERACAO
                                                                   ,[DATA] = @TESTE_DATA
                                                                   ,disciplina_id = @DISCIPLINA_ID
                                                                   ,materia_id = @MATERIA_ID
                                                                   ,[SERIE] = @SERIE
                                                                WHERE
                                                                   [ID] = @ID";

        protected override string sqlExcluir => @"DELETE FROM TBTeste WHERE [ID] = @ID;";

        protected string sqlExcluirRelacao => @"DELETE FROM [TBTESTE_QUESTAO]
                                                         WHERE [TESTE_ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT  T.[ID] AS TESTE_ID
                                                                 ,T.[NOME] AS TESTE_NOME
                                                                 ,T.[NUMEROQUESTOES] AS NUMERO_QUESTOES
                                                                 ,T.[PROVARECUPERACAO] AS PROVA_RECUPERACAO
                                                                 ,T.[DATA] AS TESTE_DATA

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
                                                                 ,T.[DATA] AS TESTE_DATA

                                                                 ,D.id AS DISCIPLINA_ID
                                                                 ,D.nome AS DISCIPLINA_NOME

                                                                 ,M.id AS MATERIA_ID
                                                                 ,M.nome AS MATERIA_NOME
                                                                 ,M.serie AS MATERIA_SERIE
                                                                 ,M.[DISCIPLINA_ID] AS MATERIA_DISCIPLINA_ID
                                                          FROM [TBTESTE] AS T 
                                                                INNER JOIN TBDisciplina AS D ON T.disciplina_id = D.id
                                                                LEFT JOIN TBMateria AS M ON T.materia_id = M.id
                                                          WHERE T.[ID] = @ID";

        protected string sqlInserirQuestoes => @"INSERT INTO [TBTESTE_QUESTAO]
                                                            ([TESTE_ID]
                                                            ,[QUESTAO_ID])
                                                        VALUES
                                                            (@TESTE_ID
                                                            ,@QUESTAO_ID)";
        protected string sqlEditarQuestoes => @"UPDATE [TBTESTE_QUESTAO]
                                                   SET  [TESTE_ID] = @TESTE_ID
                                                        ,[QUESTAO_ID] = @QUESTAO_ID
                                                 WHERE TESTE_ID = @ID";
        protected string sqlExcluirQuestoes => @"DELETE FROM [TBTESTE_QUESTAO]
                                                       WHERE TESTE_ID = @ID";
        protected string sqlSelecionarQuestoes => @"SELECT TQ.[TESTE_ID]
                                                           ,TQ.[QUESTAO_ID]
                                                           ,Q.[ID] AS QUESTAO_ID
                                                           ,Q.[MATERIA_ID] AS QUESTAO_MATERIA_ID
                                                           ,Q.[ENUNCIADO] AS QUESTAO_ENUNCIADO
                                                           ,Q.[RESPOSTA] AS QUESTAO_RESPOSTA
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
        private string sqlSelecionarAlternativas =>

               @"SELECT
                          A.ID AS ALTERNATIVA_ID,  
                          A.TITULO AS ALTERNATIVA_TITULO,  
                          A.LETRA AS ALTERNATIVA_LETRA, 
                          A.CORRETA AS ALTERNATIVA_CORRETA,

                          Q.ENUNCIADO AS QUESTAO_ENUNCIADO,  
                          Q.RESPOSTA AS QUESTAO_RESPOSTA,
                          Q.MATERIA_ID AS MATERIA_ID,  

                          M.NOME AS MATERIA_NOME,  
                          M.SERIE AS MATERIA_SERIE,
                          M.DISCIPLINA_ID AS DISCIPLINA_ID, 

                          D.NOME AS DISCIPLINA_NOME,
                          D.ID AS DISCIPLINA_ID

                     FROM
                          [TBAlternativa] AS A

                               INNER JOIN [TBQuestao] AS Q
                               ON Q.ID = A.QUESTAO_ID

                               INNER JOIN [TBMateria] AS M
                               ON Q.MATERIA_ID = M.ID

                               INNER JOIN [TBDisciplina] AS D
                               ON M.DISCIPLINA_ID = D.ID

               WHERE

                    A.QUESTAO_ID    = @QUESTAO_ID";

        public override void Inserir(Teste novoRegistro)
        {
            base.Inserir(novoRegistro);
            foreach (Questao questao in novoRegistro.listaQuestoes)
            {
                InserirQuestoes(novoRegistro.id, questao.id);
            }
            
        }
        public void CarregarQuestoes(Teste teste)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarQuestoes = conexaoComBanco.CreateCommand();
            comandoSelecionarQuestoes.CommandText = sqlSelecionarQuestoes;

            comandoSelecionarQuestoes.Parameters.AddWithValue("ID", teste.id);

            SqlDataReader leitor = comandoSelecionarQuestoes.ExecuteReader();
            while (leitor.Read())
            {
                Questao q = new MapeadorQuestao().ConverterRegistro(leitor);
                CarregarAlternativas(q);
                teste.listaQuestoes.Add(q);
            }
            conexaoComBanco.Close();
        }
        public void CarregarAlternativas(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarAlternativas = conexaoComBanco.CreateCommand();
            comandoSelecionarAlternativas.CommandText = sqlSelecionarAlternativas;

            comandoSelecionarAlternativas.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            SqlDataReader leitor = comandoSelecionarAlternativas.ExecuteReader();
            while (leitor.Read())
            {
                Alternativa alternativa = new MapeadorQuestao().ConverterRegistroAlternativas(questao, leitor);
                questao.alternativas.Add(alternativa);
            }
            conexaoComBanco.Close();
            
        }
        public virtual void ExcluirRelacao(Teste teste)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluirQuestoes;

            comandoExcluir.Parameters.AddWithValue("ID", teste.id);

            comandoExcluir.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        public void InserirQuestoes(int testeID, int questaoID)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserirQuestoes;

            comandoInserir.Parameters.AddWithValue("TESTE_ID", testeID);
            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questaoID);

            comandoInserir.ExecuteNonQuery();
            conexaoComBanco.Close();
        }
        public override List<Teste> SelecionarTodos(bool CarregarDependencias = false)
        {
            List<Teste> testes = base.SelecionarTodos(true);

            foreach (Teste teste in testes)
            {
                if (CarregarDependencias)
                    CarregarQuestoes(teste);
            }

            return testes;
        }
        public override Teste SelecionarPorId(int id)
        {
            Teste teste = base.SelecionarPorId(id);

            if (teste != null)
                CarregarQuestoes(teste);

            return teste;
        }

    }
}
