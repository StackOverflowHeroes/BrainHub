using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloTeste;
using Microsoft.Win32;
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
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            TabelaTeste.ConfigurarGridSomenteLeitura();
            TabelaTeste.ConfigurarGridZebrado();
        }

        
        public int ObterIdSelecionado()
        {
            if (TabelaTeste.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(TabelaTeste.SelectedRows[0].Cells["id"].Value);

            return id;
        }
        public void AtualizarRegistros(List<Teste> ListaCompletaDTeste)
        {
            TabelaTeste.Rows.Clear();

            foreach (Teste teste in ListaCompletaDTeste)
            {
                string serie = "";

                if (teste.serie == SerieEnum.primeiraSerie)
                    serie = "1ª série";
                else serie = "2ª série";

                TabelaTeste.Rows.Add(teste.id,
                    teste.nome,
                    teste.data.ToShortDateString(),
                    serie,
                    teste.disciplina.nome.ToUpper(),
                    teste.materia.nome.ToUpper());
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
                    Name = "serio",
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
            };

            TabelaTeste.Columns.AddRange(colunas);
        }
    }
}
