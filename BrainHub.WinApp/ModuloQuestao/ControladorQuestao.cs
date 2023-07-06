using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.WinApp.ModuloMateria;
using PartyManager.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.WinApp.ModuloQuestao
{
     public class ControladorQuestao : ControladorBase
     {
          private TabelaQuestaoControl TabelaQuestao;
          private IRepositorioMateria repositorioMateria;
          private IRepositorioQuestao repositorioQuestao;

          public ControladorQuestao(IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao)
          {
               this.repositorioMateria = repositorioMateria;
               this.repositorioQuestao = repositorioQuestao;
          }

          public override string ToolTipInserir => "Inserir questão";

          public override string ToolTipEditar => "Editar questão";

          public override string ToolTipDeletar => "Deletar questão";

          public override bool InserirHabilitado { get { return true; } }
          public override bool EditarHabilitado { get { return true; } }
          public override bool DeletarHabilitado { get { return true; } }

          public override void Inserir()
          {
               TelaQuestaoForm TelaQuestao = new TelaQuestaoForm();
               TelaQuestao.PopularComboBoxMateria(repositorioMateria.SelecionarTodos());
               TelaQuestao.PegarListaQuestoes(repositorioQuestao.SelecionarTodos());

               DialogResult opcaoEscolhida = TelaQuestao.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Questao novaQuestao = TelaQuestao.ObterQuestao();
                    repositorioQuestao.Inserir(novaQuestao);                   
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Questão inserida com sucesso!", TipoStatusEnum.Sucesso);
          }
          public override void Editar()
          {
               TelaQuestaoForm TelaQuestao = new TelaQuestaoForm();
               TelaQuestao.Text = "Edição de Questão";
               Questao questaoSelecionada = ObterQuestaoSelecionada();

               if (questaoSelecionada == null)
                    return;

               TelaQuestao.PopularComboBoxMateria(repositorioMateria.SelecionarTodos());
               TelaQuestao.ConfigurarTela(questaoSelecionada);
               TelaQuestao.PegarListaQuestoes(repositorioQuestao.SelecionarTodos());
               DialogResult opcaoEscolhida = TelaQuestao.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Questao questaoEditada = TelaQuestao.ObterQuestao();
                    repositorioQuestao.Editar(questaoEditada.id, questaoEditada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Matéria editada com sucesso!", TipoStatusEnum.Sucesso);
          }
          public override void Deletar()
          {
               Questao questaoSelecionada = ObterQuestaoSelecionada();

               if (questaoSelecionada == null || !ValidarSeEhPossivelExcluir(questaoSelecionada))
                    return;

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão ({questaoSelecionada.id}){questaoSelecionada.enunciado}?", "Exclusão de questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioQuestao.Deletar(questaoSelecionada);
               }

               CarregarRegistros();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape("Matéria deletada com sucesso!", TipoStatusEnum.Sucesso);
          }
          private bool ValidarSeEhPossivelExcluir(Questao questaoSelecionada)
          {
               bool EhPossivelExcluir = true;

               if (questaoSelecionada.materia != null)
               {
                    MessageBox.Show($"Não é possível excluir uma questão com uma matéria selecionada!","Exclusão de questões",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    EhPossivelExcluir = false;
               }

               return EhPossivelExcluir;
          }
          public override UserControl ObterListagem()
          {
               if (TabelaQuestao == null)
                    TabelaQuestao = new TabelaQuestaoControl();

               CarregarRegistros();
               return TabelaQuestao;
          }

          public override void CarregarRegistros()
          {
               List<Questao> ListaCompletaQuestao = repositorioQuestao.SelecionarTodos();
               TabelaQuestao.AtualizarRegistros(ListaCompletaQuestao);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaQuestao.Count} questão(ões)", TipoStatusEnum.Visualizando);
          }
          public override string ObterTipoCadastro()
          {
               return "Cadastro de questões";
          }

          private Questao ObterQuestaoSelecionada()
          {
               int id = TabelaQuestao.ObterIdSelecionado();
               Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(id);

               if (questaoSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma questão primeiro!",
                        "Seleção de questões",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return null;
               }

               return questaoSelecionada;


          }
     }
}
