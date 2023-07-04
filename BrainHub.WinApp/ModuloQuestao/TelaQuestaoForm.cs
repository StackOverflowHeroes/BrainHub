using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using PartyManager.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainHub.WinApp.ModuloQuestao
{
     public partial class TelaQuestaoForm : Form
     {
          private List<Questao> ListaCompletaQuestao;
          private int contagemAlternativas = 0;
          public TelaQuestaoForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public Questao ObterQuestao()
          {
               string enunciado = TextBoxEnunciado.Text;
               Materia materia = ComboBoxMateria.SelectedItem as Materia;
               List<Alternativa> alternativas = ObterListaAlternativas();

               Questao questao = new Questao(enunciado, materia, alternativas);
               return questao;
          }

          private List<Alternativa> ObterListaAlternativas()
          {
               List<Alternativa> alternativas = new List<Alternativa>();

               return alternativas = CLBoxAlternativa.Items.Cast<Alternativa>().ToList();
          }

          private bool VerificarAlternativasMarcadas(Questao novaQuestao)
          {
               if (CLBoxAlternativa.CheckedItems.Count == 0)
                    return true;

               return false;
          }

          private void botaoGravar_Click(object sender, EventArgs e)
          {
               Questao novaQuestao = ObterQuestao();

               List<string> ListaErros = novaQuestao.ValidarErros();

               if (CLBoxAlternativa.Items.Count < 2)
                    ListaErros.Add("Insira no mínimo duas alternativas!");

               if (CLBoxAlternativa.Items.Count > 4)
                    ListaErros.Add("Insira no máximo quatro alternativas!");

               if (VerificarAlternativasMarcadas(novaQuestao))
                    ListaErros.Add("Selecione uma resposta correta!");

               if (VerificarNomeDuplicado(novaQuestao.enunciado, novaQuestao.id))
                    ListaErros.Add("Não é possível cadastrar uma mesma questão duas vezes");

               if (ListaErros.Count > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }
          }

          private static void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
          {
               CheckedListBox checkedListBox = (CheckedListBox)sender;

               for (int i = 0; i < checkedListBox.Items.Count; i++)
               {
                    if (i != e.Index)
                    {
                         checkedListBox.SetItemChecked(i, false);
                    }
               }
          }

          private void botaoAdicionar_Click(object sender, EventArgs e)
          {
               Alternativa alternativa = ObterAlternativa();

               if (alternativa == null)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Insira um resultado para adicioná-lo a lista!", TipoStatusEnum.Erro);
                    return;
               }

               TextBoxResposta.Clear();
               contagemAlternativas++;
               alternativa.qtdAlternativa = contagemAlternativas;
               CLBoxAlternativa.Items.Add(alternativa);
          }

          private Alternativa ObterAlternativa()
          {
               if (string.IsNullOrEmpty(TextBoxResposta.Text) || string.IsNullOrWhiteSpace(TextBoxResposta.Text))
                    return null;

               string titulo = TextBoxResposta.Text;
               Alternativa alternativa = new Alternativa(titulo);
               return alternativa;
          }

          public void PopularComboBoxMateria(List<Materia> ListaCompletaMateria)
          {
               foreach (Materia item in ListaCompletaMateria)
               {
                    ComboBoxMateria.Items.Add(item);
               }
          }

          public void ConfigurarTela(List<Questao> ListaCompleta)
          {
               ListaCompletaQuestao = ListaCompleta;
          }

          private bool VerificarNomeDuplicado(string nome, int id)
          {
               bool NomeDuplicado = ListaCompletaQuestao.Any(questao => questao.enunciado.ToLower() == nome.ToLower() && questao.id != id);

               if (NomeDuplicado)
                    return true;
               else
                    return false;
          }

          private void botaoRemover_Click(object sender, EventArgs e)
          {
               if(CLBoxAlternativa.Items.Count != 0)
               {
               contagemAlternativas--;             
               CLBoxAlternativa.Items.RemoveAt(CLBoxAlternativa.Items.Count - 1);
               }
          }
     }
}
