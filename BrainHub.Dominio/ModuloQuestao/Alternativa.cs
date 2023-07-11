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
          public Alternativa(int id, string tituloResposta, string letraAlternativa, bool alternativaCorreta, Questao questao)
          {
               this.id = id;
               this.tituloResposta = tituloResposta;
               this.letraAlternativa = letraAlternativa;
               this.alternativaCorreta = alternativaCorreta;
               this.questao = questao;          
          }
        

        public Alternativa(string tituloResposta)
          {
               this.tituloResposta = tituloResposta;
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
