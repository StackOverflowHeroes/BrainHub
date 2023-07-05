
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloQuestao;

namespace BrainHub.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome;
        public Disciplina disciplina;
        public SerieEnum serie;
        public List<Questao> questoes;

        public Materia()
        {
        }

        public override string ToString()
        {
            string nomeSerie;

            if (serie == SerieEnum.primeiraSerie)
                nomeSerie = "1ª Série";

            else
                nomeSerie = "2ª Série";

            return $"{nome}, {nomeSerie}";
        }


        public Materia(int id, string nome, Disciplina disciplina, SerieEnum serie)
        {
            this.id = id;
            this.nome = nome;
            this.disciplina = disciplina;
            this.serie = serie;
            questoes = new List<Questao>();
        }

        public override void AtualizarRegistros(Materia registroAtualizado)
        {
            nome = registroAtualizado.nome;
            disciplina = registroAtualizado.disciplina;
            serie = registroAtualizado.serie;
        }

        public override List<string> ValidarErros()
        {
            List<string> ListaErros = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ListaErros.Add("O campo 'nome' é obrigatório");

            if (disciplina == null)
                ListaErros.Add("O campo de 'disciplina' é obrigatório");

            return ListaErros;
        }
    }
}
