using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrainHub.WinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        public TelaTesteForm(List<Materia> materias, List<Disciplina> disciplinas, List<Questao> questoes)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarMateria(materias);
            CarregarDisciplina(disciplinas);
            CarregarQuestoes(questoes);
        }

        public void CarregarQuestoes(List<Questao> questoes)
        {
            foreach (Questao questao in questoes)
            {
                listBoxQuestoes.Items.Add(questao);
            }
        }

        public void CarregarDisciplina(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                cbBoxDisciplina.Items.Add(disciplina);
            }
        }

        public void CarregarMateria(List<Materia> materias)
        {
            foreach (Materia materia in materias)
            {
                cbBoxMateria.Items.Add(materia);
            }
        }
        public void ConfigurarTela(Teste testeSelecionado)
        {
            TextBoxNome.Text = testeSelecionado.nome;
            cbBoxDisciplina.SelectedItem = testeSelecionado.disciplina;
            cbBoxMateria.SelectedItem = testeSelecionado.materia;
            //checkBoxRecuperacao.Checked = testeSelecionado.
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked)
            {
                cbBoxMateria.Enabled = true;
            }
            else
            {
                cbBoxMateria.Enabled = false;
            }
        }

        public Teste ObterTeste()
        {
            int id = 0;
            string nome = TextBoxNome.Text;
            Materia materia = (Materia)cbBoxMateria.SelectedItem;
            Disciplina disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;
            DateTime data = DateTime.Now;
            Teste teste = new Teste();




            if (id > 0)
                teste.id = id;

            return teste;
        }
    }
}
