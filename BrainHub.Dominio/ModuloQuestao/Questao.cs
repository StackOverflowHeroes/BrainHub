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
          public Questao(int id, string enunciado, string resposta, Materia materia)
          {
               this.id = id;
               this.enunciado = enunciado;
               this.resposta = resposta;
               this.materia = materia;
               alternativas = new List<Alternativa>();
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

          public bool TemAlternativa(Alternativa novaAlternativa)
          {
               if (alternativas.Contains(novaAlternativa))
                    return true;

               return false;
          }

          public void AdicionarAlternativa(Alternativa novaAlternativa)
          {
               alternativas.Add(novaAlternativa);
          }
     }
}
