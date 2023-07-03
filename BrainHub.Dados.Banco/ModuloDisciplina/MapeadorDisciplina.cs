
using BrainHub.Dominio.ModuloDisciplina;

namespace BrainHub.Dados.Banco.ModuloDisciplina
{
    public class MapeadorDisciplina : MapeadorBase<Disciplina>
    {
        public override void ConfigurarParametros(SqlCommand comando, Disciplina registro)
        {
            throw new NotImplementedException();
        }

        public override Disciplina ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }
    }
}
