
using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Banco.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);
            comando.Parameters.AddWithValue("NOME", registro.nome);
            comando.Parameters.AddWithValue("SERIE", registro.serie);
            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.disciplina.id);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int disciplina_id = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);
            string disciplina_nome = Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]);

            Disciplina disciplina = new Disciplina(disciplina_id, disciplina_nome);

            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);

            SerieEnum serie;

            if (Convert.ToInt32(leitorRegistros["MATERIA_SERIE"]) == 1)
                serie = SerieEnum.primeiraSerie;
            else
                serie = SerieEnum.segundaSerie;
            

            return new Materia(id, nome, disciplina, serie);
        }
    }
}
