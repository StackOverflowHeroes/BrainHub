
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dados.Arquivo.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Questao> PegarQuestoesMateria(Materia materia)
        {
            return materia.questoes;
        }

        protected override List<Materia> ObterRegistros()
        {
            return contextoDados.materias;
        }
    }
}
