using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.Compartilhado;
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
     public class MapeadorQuestao : MapeadorBase<Questao>
     {
          public override void ConfigurarParametros(SqlCommand comando, Questao registro)
          {
               comando.Parameters.AddWithValue("ID", registro.id);
               comando.Parameters.AddWithValue("ENUNCIADO", registro.enunciado);
               comando.Parameters.AddWithValue("MATERIA_ID", registro.materia.id);
               comando.Parameters.AddWithValue("RESPOSTA", registro.resposta);
          }
          public virtual void ConfigurarParametroAlternativa(SqlCommand comando, Alternativa registro, int id)
          {
               comando.Parameters.AddWithValue("ID", registro.id.ToString());
               comando.Parameters.AddWithValue("QUESTAO_ID", id.ToString());
               comando.Parameters.AddWithValue("TITULO", registro.tituloResposta);
               comando.Parameters.AddWithValue("LETRA", registro.letraAlternativa);
               comando.Parameters.AddWithValue("CORRETA", registro.alternativaCorreta);
          }

          public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
          {
               int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);
               string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;
               string resposta = Convert.ToString(leitorRegistros["QUESTAO_RESPOSTA"])!;

               int id_disciplina = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);
               string nome_disciplina = Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]);

               Disciplina disciplina = new Disciplina(id_disciplina,nome_disciplina);


               int id_materia = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
               string nome_materia = Convert.ToString(leitorRegistros["MATERIA_NOME"]);

               SerieEnum serie;

               if (Convert.ToInt32(leitorRegistros["MATERIA_SERIE"]) == 1)
                    serie = SerieEnum.primeiraSerie;
               else
                    serie = SerieEnum.segundaSerie;

               Materia materia = new Materia(id_materia, nome_materia, disciplina, serie);

               return new Questao(id, enunciado, resposta, materia);
          }

        private Alternativa ConverterRegistroAlternativa(SqlDataReader leitor)
        {

            int id = Convert.ToInt32(leitor["QUESTAO_ID"]);
            bool alternativacorreta = Convert.ToBoolean(leitor["ALTERNATIVA_CORRETA"]);
            string letraalternativa = Convert.ToString(leitor["ALTERNATIVA_LETRA"])!;
            string tituloresposta = Convert.ToString(leitor["ALTERNATIVA_TITULO"])!;
            int id_questao = Convert.ToInt32(leitor["QUESTAO_ID"]);
            int id_alternativa = Convert.ToInt32(leitor["ALTERNATIVA_ID"]);

            //Alternativa alternativa = new Alternativa(id, tituloresposta, letraalternativa, alternativacorreta, Questao questao);


            //if (Convert.ToInt32(leitor["MATERIA_SERIE"]) == 1)
            //    serie = SerieEnum.primeiraSerie;
            //else
            //    serie = SerieEnum.segundaSerie;

            //Materia materia = new Materia(id_materia, nome_materia, disciplina, serie);

            //return new Questao(id, enunciado, resposta, materia);
        }
    }
}
