

namespace BrainHub.Dados.Arquivo.Compartilhado
{
     public abstract class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
     {
          protected ContextoDados contextoDados;
          private int contador;

          public RepositorioArquivoBase(ContextoDados contexto)
          {
               contextoDados = contexto;
               AtualizarContador();
          }

          protected abstract List<TEntidade> ObterRegistros();

          public void AtualizarContador()
          {
               if (ObterRegistros().Count > 0)
                    contador = ObterRegistros().Max(x => x.id);
          }

          public void Inserir(TEntidade novoRegistro)
          {
               List<TEntidade> registros = ObterRegistros();

               contador++;
               novoRegistro.id = contador;
               registros.Add(novoRegistro);

               contextoDados.GravarArquivoJson();
          }

          public void Editar(int id, TEntidade registroAtualizado)
          {
               TEntidade registroSelecionado = SelecionarPorId(id);

               registroSelecionado.AtualizarRegistros(registroAtualizado);

               contextoDados.GravarArquivoJson();
          }

          public void Deletar(TEntidade registroSelecionado)
          {
               List<TEntidade> registros = ObterRegistros();

               registros.Remove(registroSelecionado);

               contextoDados.GravarArquivoJson();
          }

          public TEntidade SelecionarPorId(int id)
          {
               List<TEntidade> registros = ObterRegistros();

               return registros.FirstOrDefault(x => x.id == id);
          }

          public List<TEntidade> SelecionarTodos()
          {
               return ObterRegistros();
          }
     }
}