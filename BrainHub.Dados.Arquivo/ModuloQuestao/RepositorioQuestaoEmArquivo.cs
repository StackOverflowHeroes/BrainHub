using BrainHub.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Arquivo.ModuloQuestao
{
     public class RepositorioQuestaoEmArquivo : RepositorioArquivoBase<Questao>
     {
          public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          protected override List<Questao> ObterRegistros()
          {
               return contextoDados.questoes;
          }
     }
}
