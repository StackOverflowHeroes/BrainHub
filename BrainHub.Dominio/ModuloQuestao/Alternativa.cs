using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dominio.ModuloQuestao
{
     public class Alternativa : EntidadeBase<Alternativa>
     {
          public Questao questao;
          public string tituloResposta;
          public string letraAlternativa { get; set; }

          public bool alternativaCorreta { get; set; }

          public Alternativa()
          {

          }
          public Alternativa(string titulo)
          {
               tituloResposta = titulo;
          }

          public void DefinirAlternativaCorreta()
          {
               alternativaCorreta = true;
          }

          public void DefinirAlternativaIncorreta()
          {
               alternativaCorreta = false;
          }

          
          public override string ToString()
          {
               return $"({letraAlternativa}) - {tituloResposta}";
          }

          public override void AtualizarRegistros(Alternativa registroAtualizado)
          {
               tituloResposta = registroAtualizado.tituloResposta;
               letraAlternativa = registroAtualizado.letraAlternativa;
               alternativaCorreta = registroAtualizado.alternativaCorreta;
               questao = registroAtualizado.questao;
          }

          public override List<string> ValidarErros()
          {
               throw new NotImplementedException();
          }
     }
}
