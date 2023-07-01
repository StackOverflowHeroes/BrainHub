
using BrainHub.Dominio.ModuloDisciplina;

namespace BrainHub.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome;
        public Disciplina disciplina;
        public SerieEnum serie;
        //public List<Questao> questoes;

        public Materia()
        {
        }

        public Materia(int id, string nome, Disciplina disciplina, SerieEnum serie)
        {
            this.id = id;
            this.nome = nome;
            this.disciplina = disciplina;
            this.serie = serie;
            //questoes = new List<Questoes>();
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
