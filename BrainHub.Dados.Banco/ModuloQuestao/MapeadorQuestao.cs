using BrainHub.Dados.Banco.ModuloMateria;
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

          public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
          {
               int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);
               string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;
               string resposta = Convert.ToString(leitorRegistros["QUESTAO_RESPOSTA"])!;

               Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

               return new Questao(id, enunciado, resposta, materia);
          }

          public Alternativa ConverterAlternativa(SqlDataReader leitorAlternativa)
          {
               int id = Convert.ToInt32(leitorAlternativa["ALTERNATIVA_ID"]);
               string tituloResposta = Convert.ToString(leitorAlternativa["ALTERNATIVA_RESPOSTA"]);
               string letraAlternativa = Convert.ToString(leitorAlternativa["ALTERNATIVA_LETRA"]);
               bool alternativaCorreta = Convert.ToBoolean(leitorAlternativa["ALTERNATIVA_CORRETA"]);

               Questao questao = ConverterRegistro(leitorAlternativa);

               return new Alternativa(tituloResposta, letraAlternativa, alternativaCorreta, questao);
          }
     }
}
