using BrainHub.Dominio.ModuloQuestao;
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
     public partial class TabelaQuestaoControl : UserControl
     {
          public TabelaQuestaoControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               TabelaQuestao.ConfigurarGridSomenteLeitura();
               TabelaQuestao.ConfigurarGridZebrado();
          }

          private void ConfigurarColunas()
          {
               DataGridViewColumn[] colunas = new DataGridViewColumn[]
{
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID",
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "enunciado",
                    HeaderText = "ENUNCIADO"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "MATÉRIA"
                },
                new DataGridViewTextBoxColumn()
                {
                     Name = "resposta",
                     HeaderText = "RESPOSTA"
                }
};

               TabelaQuestao.Columns.AddRange(colunas);
          }

          public int ObterIdSelecionado()
          {
               if (TabelaQuestao.SelectedRows.Count == 0)
                    return -1;

               int id = Convert.ToInt32(TabelaQuestao.SelectedRows[0].Cells["id"].Value);

               return id;
          }

          public void AtualizarRegistros(List<Questao> ListaCompletaDQuestao)
          {
               TabelaQuestao.Rows.Clear();

               foreach (Questao questao in ListaCompletaDQuestao)
               {
                    string nomeMateria = questao.materia.nome.ToUpper();

                    TabelaQuestao.Rows.Add(questao.id, questao.enunciado, nomeMateria, questao.resposta);
               }
          }
     }
}
