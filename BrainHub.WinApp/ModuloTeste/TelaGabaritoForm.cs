using BrainHub.Dominio.ModuloQuestao;
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
    public partial class TelaGabaritoForm : Form
    {
        public TelaGabaritoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public void ConfigurarTela(Teste testeSelecionado)
        {
            string materiaNome = "";

            if (testeSelecionado.materia != null)
                materiaNome = testeSelecionado.materia.nome;

            tbNome.Text = testeSelecionado.nome;
            tbDisciplina.Text = testeSelecionado.disciplina.nome;
            tbMatéria.Text = materiaNome;

            foreach (Questao q in testeSelecionado.listaQuestoes)
            {
                listBoxQuestoes.Items.Add(q);
            }
        }

        internal void VisualizarTeste(Teste testeSelecionado)
        {
            tbNome.Text = testeSelecionado.nome;
            
        }
    }
}
