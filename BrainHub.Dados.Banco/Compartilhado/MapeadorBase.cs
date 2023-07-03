

namespace BrainHub.Dados.Banco.Compartilhado
{
    public abstract class MapeadorBase<T>
    {
        public abstract void ConfigurarParametros(SqlCommand comando, T registro);

        public abstract T ConverterRegistro(SqlDataReader leitorRegistros);
    }
}
