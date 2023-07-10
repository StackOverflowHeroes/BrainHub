using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainHub.WinApp.ModuloTeste
{
    public partial class TabelaGabaritoControl : UserControl
    {
        public TabelaGabaritoControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            TabelaGabarito.ConfigurarGridSomenteLeitura();
            TabelaGabarito.ConfigurarGridZebrado();
        }
        public int ObterIdSelecionado()
        {
            if (TabelaGabarito.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(TabelaGabarito.SelectedRows[0].Cells["id"].Value);

            return id;
        }
        public void AtualizarRegistros(List<Teste> ListaCompletaDTeste)
        {
            TabelaGabarito.Rows.Clear();

            foreach (Teste teste in ListaCompletaDTeste)
            {
                string serie = "";
                string materia = "";

                if (teste.materia == null)
                    materia = string.Empty;
                else
                    materia = teste.materia.nome.ToUpper();

                if (teste.serie == SerieEnum.primeiraSerie)
                    serie = "1ª série";
                else serie = "2ª série";

                TabelaGabarito.Rows.Add(teste.id,
                    teste.nome,
                    teste.data.ToShortDateString(),
                    serie,
                    teste.disciplina.nome.ToUpper(),
                    materia); //adicionar questao e resposta
            }
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
                    Name = "nome",
                    HeaderText= "NOME"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText= "DATA"
                },new DataGridViewTextBoxColumn()
                {
                    Name = "serie",
                    HeaderText= "SÉRIE"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText= "DISCIPLINA"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText= "MATÉRIA"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "questao",
                    HeaderText= "QUESTÃO"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "resposta",
                    HeaderText= "RESPOSTA"
                },
            };

            TabelaGabarito.Columns.AddRange(colunas);
        }
    }
}
