using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloMateria
{
     public class ControladorMateria : ControladorBase
     {
          private TabelaMateriaControl TabelaMateria;
          private IRepositorioMateria repositorioMateria;
          private IRepositorioDisciplina repositorioDisciplina;

          public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
          {
               this.repositorioMateria = repositorioMateria;
               this.repositorioDisciplina = repositorioDisciplina;
          }

          public override string ToolTipInserir => "Inserir matéria";
          public override string ToolTipEditar => "Editar matéria";
          public override string ToolTipDeletar => "Deletar matéria";
          public override bool InserirHabilitado { get { return true; } }
          public override bool EditarHabilitado { get { return true; } }
          public override bool DeletarHabilitado { get { return true; } }

          public override void Inserir()
          {
               TelaMateriaForm TelaMateria = new TelaMateriaForm();
               TelaMateria.PopularComboBoxDisciplina(repositorioDisciplina.SelecionarTodos());
               TelaMateria.ConfigurarTela(repositorioMateria.SelecionarTodos());

               DialogResult opcaoEscolhida = TelaMateria.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Materia novaMateria = TelaMateria.ObterMateria();
                    repositorioMateria.Inserir(novaMateria);
                    AdicionarMateriaNaDisciplina(novaMateria);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Matéria inserida com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Editar()
          {
               TelaMateriaForm TelaMateria = new TelaMateriaForm();
               TelaMateria.Text = "Edição de Matéria";
               Materia materiaSelecionada = ObterMateriaSelecionada();

               if (materiaSelecionada == null)
                    return;

               TelaMateria.ConfigurarTela(repositorioMateria.SelecionarTodos());
               TelaMateria.PopularComboBoxDisciplina(repositorioDisciplina.SelecionarTodos());
               TelaMateria.PopularDialog(materiaSelecionada);

               DialogResult opcaoEscolhida = TelaMateria.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Materia materiaEditada = TelaMateria.ObterMateria();
                    repositorioMateria.Editar(materiaEditada.id, materiaEditada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Matéria editada com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Deletar()
          {
               Materia materiaSelecionada = ObterMateriaSelecionada();

               if (materiaSelecionada == null || !ValidarSeEhPossivelExcluir(materiaSelecionada))
                    return;

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materiaSelecionada.nome.ToUpper()}?", "Exclusão de matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioMateria.Deletar(materiaSelecionada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Matéria deletada com sucesso!", TipoStatusEnum.Sucesso);
          }

          private bool ValidarSeEhPossivelExcluir(Materia materiaSelecionada)
          {
               bool EhPossivelExcluir = true;

               //if (materiaSelecionada.questoes.Count > 0)
               //{
               //    MessageBox.Show("Não é possível excluir uma matéria com questões cadastradas");
               //    EhPossivelExcluir = false;
               //}

               return EhPossivelExcluir;
          }

          private void AdicionarMateriaNaDisciplina(Materia novaMateria)
          {
               Disciplina disciplina = novaMateria.disciplina;
               disciplina.AdicionarMateria(novaMateria);
          }

          private Materia ObterMateriaSelecionada()
          {
               int id = TabelaMateria.ObterIdSelecionado();
               Materia materiaSelecionada = repositorioMateria.SelecionarPorId(id);

               if (materiaSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma matéria primeiro!",
                        "Seleção de matérias",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return null;
               }

               return materiaSelecionada;


          }

          public override void CarregarRegistros()
          {
               List<Materia> ListaCompletaMateria = repositorioMateria.SelecionarTodos();
               TabelaMateria.AtualizarRegistros(ListaCompletaMateria);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaMateria.Count} matéria(s)", TipoStatusEnum.Visualizando);
          }

          public override UserControl ObterListagem()
          {
               if (TabelaMateria == null)
                    TabelaMateria = new TabelaMateriaControl();

               CarregarRegistros();
               return TabelaMateria;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de matérias";
          }
     }
}
