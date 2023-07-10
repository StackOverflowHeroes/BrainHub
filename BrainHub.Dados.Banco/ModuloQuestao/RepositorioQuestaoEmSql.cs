using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloQuestao
{
     public class RepositorioQuestaoEmSql : RepositorioSqlBase<Questao, MapeadorQuestao>, IRepositorioQuestao
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

          private string sqlEditarAlternativa =>

               @"UPDATE [TBAlternativa] 
                    SET
                         QUESTAO_ID = @QUESTAO_ID,
                         TITULO = @TITULO,
                         LETRA = @LETRA,
                         CORRETA = @CORRETA

                    WHERE
                         ID = @ID";

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

          public override void Inserir(Questao novoRegistro)
          {
               base.Inserir(novoRegistro);

               foreach (Alternativa alternativa in novoRegistro.alternativas)
               {
                    InserirAlternativa(alternativa, novoRegistro.id);
               }
          }

          public override void Editar(int id, Questao registro)
          {
               foreach (Alternativa alternativa in registro.alternativas)
               {
                    DeletarAlternativas(alternativa, registro.id);
               }

               base.Editar(id, registro);

               foreach(Alternativa alternativa in registro.alternativas)
               {
                    InserirAlternativa(alternativa, registro.id);
               }            
          }

          public override void Deletar(Questao registroSelecionado)
          {             
               foreach(Alternativa alternativa in registroSelecionado.alternativas)
               {
                    DeletarAlternativas(alternativa, registroSelecionado.id);
               }
               base.Deletar(registroSelecionado);
          }

          private void DeletarAlternativas(Alternativa alternativa, int id_questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoExcluirAlternativa = conexaoComBanco.CreateCommand();
               comandoExcluirAlternativa.CommandText = sqlExcluirAlternativa;

               MapeadorQuestao mapeador = new MapeadorQuestao();
               mapeador.ConfigurarParametroAlternativa(comandoExcluirAlternativa, alternativa, id_questao);

               object id = comandoExcluirAlternativa.ExecuteScalar();
               
               alternativa.id = Convert.ToInt32(id);

               conexaoComBanco.Close();
          }

          private void EditarAlternativa(Alternativa alternativa, int id_questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoEditarAlternativa = conexaoComBanco.CreateCommand();
               comandoEditarAlternativa.CommandText = sqlEditarAlternativa;

               MapeadorQuestao mapeador = new MapeadorQuestao();
               mapeador.ConfigurarParametroAlternativa(comandoEditarAlternativa, alternativa, id_questao);

               object id = comandoEditarAlternativa.ExecuteScalar();
               alternativa.id = Convert.ToInt32(id);

               conexaoComBanco.Close();
          }

          public List<Questao> SelecionarTodos(bool carregarAlternativa = false)
          {
               List<Questao> listaQuestoes = base.SelecionarTodos();

               foreach (Questao questao in listaQuestoes)
               {
                    if (carregarAlternativa)
                         CarregarAlternativas(questao);
               }


               return listaQuestoes;
          }

          public override Questao SelecionarPorId(int id)
          {
               Questao questao = base.SelecionarPorId(id);

               if (questao != null)
                    CarregarAlternativas(questao);

               return questao;
          }

          private void CarregarAlternativas(Questao questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoCarregarAlternativas = conexaoComBanco.CreateCommand();
               comandoCarregarAlternativas.CommandText = sqlSelecionarAlternativas;

               comandoCarregarAlternativas.Parameters.AddWithValue("QUESTAO_ID", questao.id);

               SqlDataReader leitorMateria = comandoCarregarAlternativas.ExecuteReader();

               while (leitorMateria.Read())
               {
                    Alternativa alternativa = ConverterAlternativa(questao, leitorMateria);

                    questao.AdicionarAlternativa(alternativa);
               }

               conexaoComBanco.Close();

          }

          private void InserirAlternativa(Alternativa alternativa, int id_questao)
          {
               SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
               conexaoComBanco.Open();

               SqlCommand comandoInserirAlternativa = conexaoComBanco.CreateCommand();
               comandoInserirAlternativa.CommandText = sqlInserirAlternativa;

               MapeadorQuestao mapeador = new MapeadorQuestao();
               mapeador.ConfigurarParametroAlternativa(comandoInserirAlternativa, alternativa, id_questao);

               object id = comandoInserirAlternativa.ExecuteScalar();
               alternativa.id = Convert.ToInt32(id);

               conexaoComBanco.Close();
          }

          private Alternativa ConverterAlternativa(Questao questao, SqlDataReader leitorAlternativa)
          {
               int id = Convert.ToInt32(leitorAlternativa["ALTERNATIVA_ID"]);
               string tituloResposta = Convert.ToString(leitorAlternativa["ALTERNATIVA_TITULO"]);
               string letraAlternativa = Convert.ToString(leitorAlternativa["ALTERNATIVA_LETRA"]);
               bool alternativaCorreta = Convert.ToBoolean(leitorAlternativa["ALTERNATIVA_CORRETA"]);

               return new Alternativa(id, tituloResposta, letraAlternativa, alternativaCorreta, questao);
          }
     }
}
