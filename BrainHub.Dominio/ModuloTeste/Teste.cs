
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string nome { get; set; }
        public int numeroQuestoes { get; set; }
        public Disciplina disciplina { get; set; }
        public Materia materia { get; set; }
        public List<Questao> listaQuestoes { get; set; }
        public bool provaRecuperacao { get; set; }
        public SerieEnum serie { get; set; }

        public DateTime data;

        public Teste()
        {

        }

        public Teste(string nome, int numeroQuestoes, Disciplina disciplina, Materia materia, List<Questao> listaQuestoes, bool provaRecuperacao, DateTime data)
        {
            this.id = id;
            this.nome = nome;
            this.numeroQuestoes = numeroQuestoes;
            this.disciplina = disciplina;
            this.materia = materia;
            this.listaQuestoes = listaQuestoes;
            this.provaRecuperacao = provaRecuperacao;
            this.data = data;
        }

        public override void AtualizarRegistros(Teste registroAtualizado)
        {
            nome = registroAtualizado.nome;
            numeroQuestoes = registroAtualizado.numeroQuestoes;
            disciplina = registroAtualizado.disciplina;
            materia = registroAtualizado.materia;
            listaQuestoes = registroAtualizado.listaQuestoes;
            data = registroAtualizado.data;
        }

        public override List<string> ValidarErros()
        {
            List<string> ListaErros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                ListaErros.Add("O campo 'nome' é obrigatorio");

            if (nome.Length < 4)
                ListaErros.Add("O campo 'nome' deve conter no mínimo 4 caracteres");

            if (disciplina == null)
                ListaErros.Add("O campo  'disciplina' é obrigatorio");

            return ListaErros;
        }
        public override bool Equals(object? obj)
        {
            return obj is Teste teste &&
                id == teste.id &&
                nome == teste.nome &&
                numeroQuestoes == teste.numeroQuestoes &&
                materia == teste.materia &&
                data == teste.data &&
                disciplina == teste.disciplina &&
                listaQuestoes == teste.listaQuestoes &&
                provaRecuperacao == teste.provaRecuperacao &&
                EqualityComparer<Materia>.Default.Equals(materia, teste.materia) &&
                EqualityComparer<Disciplina>.Default.Equals(disciplina, teste.disciplina);
        }
    }
}
