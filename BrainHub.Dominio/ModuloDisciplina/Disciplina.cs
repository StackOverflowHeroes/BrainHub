﻿
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string nome { get; set; }

        public List<Materia> materias = new List<Materia>();

        public Disciplina()
        {
        }

        public Disciplina(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public override void AtualizarRegistros(Disciplina registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }

        public override List<string> ValidarErros()
        {
            List<string> ListaErros = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ListaErros.Add("O campo 'nome' é obrigatório");

            return ListaErros;
        }

        public void AdicionarMateria(Materia novaMateria)
        {
            materias.Add(novaMateria);
        }

          public override bool Equals(object? obj)
          {
               return obj is Disciplina disciplina &&
                      id == disciplina.id &&
                      nome == disciplina.nome;
          }
     }
}
