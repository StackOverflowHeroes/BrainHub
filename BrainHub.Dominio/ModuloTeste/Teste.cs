
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string nome;
        public int numeroQuestoes;
        public Disciplina disciplina { get; set; }
        public Materia materia { get; set; }
        public List<Questao> questoes;
        public SerieEnum serie;
        public DateTime data;

        public Teste()
        {

        }

        public Teste(int id, string nome, int numeroQuestoes, Disciplina disciplina, Materia materia, SerieEnum serie, DateTime data)
        {
            this.id = id;
            this.nome = nome;
            this.numeroQuestoes = numeroQuestoes;
            this.disciplina = disciplina;
            this.materia = materia;
            this.serie = serie;
            this.data = data;
            questoes = new List<Questao>();
        }

        public override void AtualizarRegistros(Teste registroAtualizado)
        {
            nome = registroAtualizado.nome;
            numeroQuestoes = registroAtualizado.numeroQuestoes;
            disciplina = registroAtualizado.disciplina;
            materia = registroAtualizado.materia;
            serie = registroAtualizado.serie;
            data = registroAtualizado.data;
        }

        public override List<string> ValidarErros()
        {
            throw new NotImplementedException();
        }
    }
}
