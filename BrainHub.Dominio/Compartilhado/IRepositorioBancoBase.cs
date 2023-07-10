namespace BrainHub.Dominio.Compartilhado
{
    public interface IRepositorioBancoBase<T>
    {    
        public void Inserir(T registro);
        public void Editar(int id, T registro);
        public void Deletar(T registro);
        public List<T> SelecionarTodos(bool carregarDependencias = false);
        public T SelecionarPorId(int id);
    }
}
