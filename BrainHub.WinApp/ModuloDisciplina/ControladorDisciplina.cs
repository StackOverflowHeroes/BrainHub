
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloDisciplina
{
     public class ControladorDisciplina : ControladorBase
     {
          private TabelaDisciplinaControl TabelaDisciplina;
          private IRepositorioDisciplina repositorioDisciplina;

          public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
          {
               this.repositorioDisciplina = repositorioDisciplina;
          }

          public override string ToolTipInserir => "Inserir disciplina";
          public override string ToolTipEditar => "Editar disciplina";
          public override string ToolTipDeletar => "Deletar disciplina";

          public override bool InserirHabilitado { get { return true; } }
          public override bool EditarHabilitado { get { return true; } }
          public override bool DeletarHabilitado { get { return true; } }

          public override void Inserir()
          {
               TelaDisciplinaForm TelaDisciplina = new TelaDisciplinaForm();
               TelaDisciplina.ConfigurarTela(repositorioDisciplina.SelecionarTodos());

               DialogResult opcaoEscolhida = TelaDisciplina.ShowDialog();
               if (opcaoEscolhida == DialogResult.OK)
               {
                    Disciplina novaDisciplina = TelaDisciplina.ObterDisciplina();
                    repositorioDisciplina.Inserir(novaDisciplina);
               }
               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Disciplina inserida com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Editar()
          {
               TelaDisciplinaForm TelaDisciplina = new TelaDisciplinaForm();
               TelaDisciplina.Text = "Edição de Disciplina";
               Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

               if (disciplinaSelecionada == null)
                    return;

               TelaDisciplina.ConfigurarTela(repositorioDisciplina.SelecionarTodos());
               TelaDisciplina.PopularDialog(disciplinaSelecionada);

               DialogResult opcaoEscolhida = TelaDisciplina.ShowDialog();
               if (opcaoEscolhida == DialogResult.OK)
               {
                    Disciplina disciplinaEditada = TelaDisciplina.ObterDisciplina();
                    repositorioDisciplina.Editar(disciplinaEditada.id, disciplinaEditada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Disciplina editada com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Deletar()
          {
               Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

               if (disciplinaSelecionada == null || !ValidarSeEhPossivelExcluir(disciplinaSelecionada))
                    return;

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina {disciplinaSelecionada.nome.ToUpper()}?", "Exclusão de Disciplina",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioDisciplina.Deletar(disciplinaSelecionada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Disciplina deletada com sucesso!", TipoStatusEnum.Sucesso);
          }

          private bool ValidarSeEhPossivelExcluir(Disciplina disciplinaSelecionada)
          {
               bool EhPossivelExcluir = true;

               if (disciplinaSelecionada.materias.Count > 0)
               {
                    MessageBox.Show("Não é possível excluir uma disciplina com matérias cadastradas");
                    EhPossivelExcluir = false;
               }

               return EhPossivelExcluir;
          }

          private Disciplina ObterDisciplinaSelecionada()
          {
               int id = TabelaDisciplina.ObterIdSelecionado();
               Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(id);

               if (disciplinaSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma disciplina primeiro!",
                        "Seleção de disciplinas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return null;
               }

               return disciplinaSelecionada;


          }

          public override void CarregarRegistros()
          {
               List<Disciplina> ListaCompletaDisciplina = repositorioDisciplina.SelecionarTodos();
               TabelaDisciplina.AtualizarRegistros(ListaCompletaDisciplina);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaDisciplina.Count} disciplina(s)", TipoStatusEnum.Visualizando);
          }

          public override UserControl ObterListagem()
          {
               if (TabelaDisciplina == null)
                    TabelaDisciplina = new TabelaDisciplinaControl();

               CarregarRegistros();
               return TabelaDisciplina;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de disciplinas";
          }



     }
}
