
using BrainHub.Dominio.ModuloDisciplina;

namespace BrainHub.Dados.Banco.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioSqlBase<Disciplina, MapeadorDisciplina>
    {
        protected override string sqlInserir => throw new NotImplementedException();

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => throw new NotImplementedException();

        protected override string sqlSelecionarPorId => throw new NotImplementedException();
    }
}
