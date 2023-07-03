
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioSqlBase<Materia, MapeadorMateria>, IRepositorioMateria
    {
        protected override string sqlInserir => throw new NotImplementedException();

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => throw new NotImplementedException();

        protected override string sqlSelecionarPorId => throw new NotImplementedException();
    }
}
