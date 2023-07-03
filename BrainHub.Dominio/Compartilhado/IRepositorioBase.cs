namespace BrainHub.Dominio.Compartilhado
{
    public interface IRepositorioBase<T>
    {    
        public void Inserir(T registro);
        public void Editar(int id, T registro);
        public void Deletar(T registro);
        public List<T> SelecionarTodos();
        public T SelecionarPorId(int id);
    }
}
