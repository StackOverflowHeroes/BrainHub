using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dados.Arquivo.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioArquivoBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Questao> PegarQuestoesDaDisciplina(Disciplina disciplina)
        {
            List<Questao> TodasQuestoesDisciplina = new List<Questao>();

            foreach(Materia materia in disciplina.materias)
            {
                TodasQuestoesDisciplina.AddRange(materia.questoes);
            }

            return TodasQuestoesDisciplina;
        }
      

        protected override List<Disciplina> ObterRegistros()
        {
            return contextoDados.disciplinas;
        }
    }
}
