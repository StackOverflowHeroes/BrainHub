
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string nome;
        public int numeroQuestoes;
        public Disciplina disciplina { get; set; }
        public Materia materia { get; set; }
        public SerieEnum serie;

        public Teste()
        {

        }

        public Teste(string nome, int numeroQuestoes, Disciplina disciplina, Materia materia, SerieEnum serie)
        {
            this.nome = nome;
            this.numeroQuestoes = numeroQuestoes;
            this.disciplina = disciplina;
            this.materia = materia;
            this.serie = serie;
        }

        public override void AtualizarRegistros(Teste registroAtualizado)
        {
            nome = registroAtualizado.nome;
            numeroQuestoes = registroAtualizado.numeroQuestoes;
            disciplina = registroAtualizado.disciplina;
            materia = registroAtualizado.materia;
            serie = registroAtualizado.serie;
        }

        public override List<string> ValidarErros()
        {
            throw new NotImplementedException();
        }
    }
}
