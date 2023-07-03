
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            throw new NotImplementedException();
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }
    }
}
