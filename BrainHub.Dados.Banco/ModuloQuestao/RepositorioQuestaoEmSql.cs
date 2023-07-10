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

          public void Inserir(Questao questao, List<Alternativa> alternativas)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
               comandoInserir.CommandText = sqlInserir;

               MapeadorQuestao mapeador = new MapeadorQuestao();
               mapeador.ConfigurarParametros(comandoInserir, questao);

               object id = comandoInserir.ExecuteScalar();

               questao.id = Convert.ToInt32(id);

               conexaoComBanco.Close();

               foreach (Alternativa alternativa in alternativas)
               {
                    if (questao.alternativas.Contains(alternativa) == false)
                    {
                         AdicionarAlternativa(alternativa, questao);
                    }
               }
          }

          public void Editar(int id, Questao questao, List<Alternativa> alternativas)
          {
               foreach (Alternativa alternativaParaAdicionar in alternativas)
               {
                    if (questao.TemAlternativa(alternativaParaAdicionar))
                         continue;

                    AdicionarAlternativa(alternativaParaAdicionar, questao);
                    questao.AdicionarAlternativa(alternativaParaAdicionar);
               }

               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
               comandoEditar.CommandText = sqlEditar;

               MapeadorQuestao mapeador = new MapeadorQuestao();
               mapeador.ConfigurarParametros(comandoEditar, questao);

               comandoEditar.ExecuteNonQuery();

               conexaoComBanco.Close();
          }

          public override void Deletar(Questao questao)
          {
               ExcluirAlternativa(questao);

               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

               SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

               comandoExclusao.Parameters.AddWithValue("ID", questao.id);

               conexaoComBanco.Open();

               int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

               conexaoComBanco.Close();
          }

          public override Questao SelecionarPorId(int id)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
               comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

               comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

               SqlDataReader leitorTemas = comandoSelecionarPorId.ExecuteReader();

               Questao questao = null;

               if (leitorTemas.Read())
               {
                    MapeadorQuestao mapeador = new MapeadorQuestao();
                    questao = mapeador.ConverterRegistro(leitorTemas);
               }

               conexaoComBanco.Close();

               if (questao != null)
               {
                    SelecionarAlternativas(questao);
               }

               return questao;
          }

          public List<Questao> SelecionarTodos(bool carregarItens = false, bool carregarAlugueis = false)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
               comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

               SqlDataReader leitorTemas = comandoSelecionarTodos.ExecuteReader();

               List<Questao> questoes = new List<Questao>();

               while (leitorTemas.Read())
               {
                    MapeadorQuestao mapeador = new MapeadorQuestao();
                    Questao questao = mapeador.ConverterRegistro(leitorTemas);

                    if (carregarItens)
                         SelecionarAlternativas(questao);

                    questoes.Add(questao);
               }

               conexaoComBanco.Close();

               return questoes;
          }

          private void AdicionarAlternativa(Alternativa alternativa, Questao questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
               comandoInserir.CommandText = sqlInserirAlternativa;

               comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
               comandoInserir.Parameters.AddWithValue("TITULO", alternativa.tituloResposta);
               comandoInserir.Parameters.AddWithValue("LETRA", alternativa.letraAlternativa);
               comandoInserir.Parameters.AddWithValue("CORRETA", alternativa.alternativaCorreta);

               comandoInserir.ExecuteNonQuery();

               conexaoComBanco.Close();
          }

          private void SelecionarAlternativas(Questao questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoSelecionarAlternativas = conexaoComBanco.CreateCommand();
               comandoSelecionarAlternativas.CommandText = sqlSelecionarAlternativas;

               comandoSelecionarAlternativas.Parameters.AddWithValue("QUESTAO_ID", questao.id);
               comandoSelecionarAlternativas.Parameters.AddWithValue("MATERIA_ID", questao.materia.id);
               comandoSelecionarAlternativas.Parameters.AddWithValue("DISCIPLINA_ID", questao.materia.disciplina.id);

               SqlDataReader leitorAlternativa = comandoSelecionarAlternativas.ExecuteReader();

               while (leitorAlternativa.Read())
               {
                    MapeadorQuestao mapeador = new MapeadorQuestao();

                    Alternativa alternativa = mapeador.ConverterAlternativa(leitorAlternativa);

                    questao.AdicionarAlternativa(alternativa);
               }

               conexaoComBanco.Close();
          }

          private void ExcluirAlternativa(Questao questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

               SqlCommand comandoExclusao = new SqlCommand(sqlExcluirAlternativa, conexaoComBanco);

               comandoExclusao.Parameters.AddWithValue("QUESTAO_ID", questao.id);

               conexaoComBanco.Open();
               comandoExclusao.ExecuteNonQuery();

               conexaoComBanco.Close();
          }

     }
}
