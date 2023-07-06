using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using PartyManager.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrainHub.WinApp.ModuloQuestao
{
     public partial class TelaQuestaoForm : Form
     {
          private List<Questao> ListaCompletaQuestao;
          private string resposta = " ";

          public TelaQuestaoForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public Questao ObterQuestao()
          {
               int id = Convert.ToInt32(TextBoxId.Text);
               string enunciado = TextBoxEnunciado.Text;
               Materia? materia = ComboBoxMateria.SelectedItem as Materia;
               List<Alternativa> alternativas = ObterListaAlternativas();
               DefinirAlternativaCorreta(alternativas);
               Questao questao = new Questao(enunciado, materia, alternativas, id);

               if (id > 0)
                    questao.id = id;

               questao.resposta = resposta;
               questao.materia.questoes.Add(questao);
               return questao;
          }

          private void DefinirAlternativaCorreta(List<Alternativa> alternativas)
          {
               foreach (Alternativa alternativa in alternativas)
               {
                    if (CLBoxAlternativa.CheckedItems.Contains(alternativa))
                         alternativa.DefinirAlternativaCorreta();

                    else
                         alternativa.DefinirAlternativaIncorreta();
               }
          }

          private List<Alternativa> ObterListaAlternativas()
          {
               return CLBoxAlternativa.Items.Cast<Alternativa>().ToList();
          }

          private void DefinirLetraAlternativas(Alternativa alternativa)
          {
               if (CLBoxAlternativa.Items.Count == 0)
                    alternativa.letraAlternativa = "A";

               else if (CLBoxAlternativa.Items.Count == 1)
                    alternativa.letraAlternativa = "B";

               else if (CLBoxAlternativa.Items.Count == 2)
                    alternativa.letraAlternativa = "C";

               else if (CLBoxAlternativa.Items.Count == 3)
                    alternativa.letraAlternativa = "D";
          }

          public bool NaoTemAlternativaMarcada()
          {
               if (CLBoxAlternativa.CheckedItems.Count == 0)
               {
                    return true;
               }
               return false;
          }

          private void botaoGravar_Click(object sender, EventArgs e)
          {
               Questao novaQuestao = ObterQuestao();

               List<string> ListaErros = novaQuestao.ValidarErros();
               VerificarErros(novaQuestao, ListaErros);

               if (ListaErros.Count > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }      
               
               foreach(Alternativa alternativa in novaQuestao.alternativas)
               {
                    if (alternativa.alternativaCorreta)
                         resposta = alternativa.letraAlternativa;
               }
          }

          public void PegarListaQuestoes(List<Questao> listaQuestoes)
          {
               ListaCompletaQuestao = listaQuestoes;
          }

          private void VerificarErros(Questao novaQuestao, List<string> ListaErros)
          {
               if (CLBoxAlternativa.Items.Count < 2)
                    ListaErros.Add("Insira no mínimo duas alternativas!");

               if (NaoTemAlternativaMarcada())
                    ListaErros.Add("Selecione uma resposta correta!");

               if (VerificarNomeDuplicado(novaQuestao.enunciado, novaQuestao.id))
                    ListaErros.Add("Não é possível cadastrar uma mesma questão duas vezes");
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

               if (VerificarAtributoDuplicado(alternativa))
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Insira um resultado diferente para adicioná-lo a lista!", TipoStatusEnum.Erro);
                    return;
               }

               DefinirLetraAlternativas(alternativa);

               if (CLBoxAlternativa.Items.Count >= 4)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Insira no máximo quatro alternativas!", TipoStatusEnum.Erro);
                    return;
               }

               TextBoxResposta.Clear();
               CLBoxAlternativa.Items.Add(alternativa);
          }

          private bool VerificarAtributoDuplicado(Alternativa novaAlternativa)
          {
               foreach (Alternativa alternativa in CLBoxAlternativa.Items)
               {
                    if (alternativa.tituloResposta == novaAlternativa.tituloResposta)
                    {
                         return true;
                    }
               }
               return false;
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

          public void ConfigurarTela(Questao questao)
          {
               TextBoxId.Text = questao.id.ToString();
               TextBoxEnunciado.Text = questao.enunciado;
               ComboBoxMateria.SelectedItem = questao.materia;

               int contador = 0;

               foreach (Alternativa alternativa in questao.alternativas)
               {
                    CLBoxAlternativa.Items.Add(alternativa);

                    if (alternativa.alternativaCorreta)
                         CLBoxAlternativa.SetItemChecked(contador, true);

                    else
                         CLBoxAlternativa.SetItemChecked(contador, false);

                    contador++;
               }
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
               if (CLBoxAlternativa.Items.Count != 0)
               {
                    CLBoxAlternativa.Items.RemoveAt(CLBoxAlternativa.Items.Count - 1);
               }
          }
     }
}
