
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Arquivo.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Materia> ObterRegistros()
        {
            return contextoDados.materias;
        }
    }
}
