using BrainHub.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dominio.ModuloQuestao
{
     public class Questao : EntidadeBase<Questao>
     {
          public string enunciado;
          public Materia materia;
          public string resposta { get; set; }
          public List<Alternativa> alternativas { get; set; }

          public Questao()
          {

          }
          public Questao(string enunciado, Materia materia, List<Alternativa> alternativas, int id)
          {
               this.enunciado = enunciado;
               this.materia = materia;
               this.alternativas = alternativas;
               this.id = id;
          }

          public override void AtualizarRegistros(Questao registroAtualizado)
          {
               enunciado = registroAtualizado.enunciado;
               alternativas = registroAtualizado.alternativas;
               materia = registroAtualizado.materia;
               resposta = registroAtualizado.resposta;
          }

          public override string ToString()
          {
               return enunciado;
          }

          public override List<string> ValidarErros()
          {
               List<string> erros = new List<string>();

               if (enunciado.Length < 10)
                    erros.Add("O campo \"Enunciado\" deve conter no mínimo 10 caracteres!");

               if (string.IsNullOrEmpty(enunciado) || (string.IsNullOrWhiteSpace(enunciado)))
                    erros.Add("O campo \"Enunciado\" está vazio ou possui espaços em branco!");

               if (materia == null)
                    erros.Add("Selecione uma matéria!");

               return erros;
          }
     }
}
