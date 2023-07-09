using BrainHub.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloQuestao
{
     public class RepositorioQuestaoEmSql : RepositorioSqlBase<Questao, MapeadorQuestao>
     {
          protected override string sqlInserir => @"";

          protected override string sqlEditar => @"";

          protected override string sqlExcluir => @"";

          protected override string sqlSelecionarTodos => @"";

          protected override string sqlSelecionarPorId => @"";
     }
}
