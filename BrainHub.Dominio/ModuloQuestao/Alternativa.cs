using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dominio.ModuloQuestao
{
     public class Alternativa
     {
          public string tituloResposta;
          public int qtdAlternativa { get; set; }

          public Alternativa()
          {

          }
          public Alternativa(string titulo)
          {
               tituloResposta = titulo;
          }

          public override string ToString()
          {
               return $"({qtdAlternativa}) - {tituloResposta}";
          }

          public override bool Equals(object? obj)
          {
               return obj is Alternativa alternativa &&
                      tituloResposta == alternativa.tituloResposta;
          }
     }
}
