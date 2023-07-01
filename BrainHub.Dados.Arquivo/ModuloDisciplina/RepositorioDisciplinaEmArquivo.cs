using BrainHub.Dominio.ModuloDisciplina;

namespace BrainHub.Dados.Arquivo.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioArquivoBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contextoDados.disciplinas;
        }
    }
}
