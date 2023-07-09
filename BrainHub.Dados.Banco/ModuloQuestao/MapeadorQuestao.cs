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
               throw new NotImplementedException();
          }

          public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
          {
               throw new NotImplementedException();
          }
     }
}
