
using BrainHub.Dominio.Compartilhado;
using Microsoft.Data.SqlClient;

namespace BrainHub.Dados.Banco.Compartilhado
{
    public abstract class RepositorioSqlBase<T, TMapeador>
        where T : EntidadeBase<T>
        where TMapeador : MapeadorBase<T>, new()
    {

        protected const string enderecoBanco = @"";
        protected abstract string sqlInserir { get; }
        protected abstract string sqlEditar { get; }
        protected abstract string sqlExcluir { get; }
        protected abstract string sqlSelecionarTodos { get; }
        protected abstract string sqlSelecionarPorId { get; }

        public virtual void Inserir(T novoRegistro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            TMapeador mapeador = new TMapeador();
            mapeador.ConfigurarParametros(comandoInserir, novoRegistro);

            object id = comandoInserir.ExecuteScalar();
            novoRegistro.id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

        public virtual void Editar(int id, T registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
            comandoEditar.CommandText = sqlEditar;

            TMapeador mapeador = new TMapeador();
            mapeador.ConfigurarParametros(comandoEditar, registro);

            comandoEditar.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public virtual void Excluir(T registroSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluir;

            comandoExcluir.Parameters.AddWithValue("ID", registroSelecionado.id);

            comandoExcluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public virtual T SelecionarPorId(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
            comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

            comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

            SqlDataReader leitorItems = comandoSelecionarPorId.ExecuteReader();

            T registro = null;

            TMapeador mapeador = new TMapeador();

            if (leitorItems.Read())
                registro = mapeador.ConverterRegistro(leitorItems);

            conexaoComBanco.Close();

            return registro;
        }

        public virtual List<T> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            SqlDataReader leitorItens = comandoSelecionarTodos.ExecuteReader();

            List<T> registros = new List<T>();

            TMapeador mapeador = new TMapeador();

            while (leitorItens.Read())
            {
                T registro = mapeador.ConverterRegistro(leitorItens);

                registros.Add(registro);
            }

            conexaoComBanco.Close();

            return registros;
        }
    }
}
