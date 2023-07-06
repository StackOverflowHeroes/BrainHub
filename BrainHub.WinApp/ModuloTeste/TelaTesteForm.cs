using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrainHub.WinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private List<Teste> listaTestes;
        private List<Questao> questaoDisponivel;

        public TelaTesteForm(List<Materia> materias, List<Disciplina> disciplinas, List<Questao> questoes)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarMateria(materias);
            CarregarDisciplina(disciplinas);
            this.questaoDisponivel = questoes;
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
            tbId.Text = testeSelecionado.id.ToString();
            TextBoxNome.Text = testeSelecionado.nome;
            numericQuestoes.Text = testeSelecionado.listaQuestoes.ToString();
            cbBoxDisciplina.SelectedItem = testeSelecionado.disciplina;
            cbBoxMateria.SelectedItem = testeSelecionado.materia;
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked == false)
            {
                cbBoxMateria.Enabled = false;
            }
            else
            {
                cbBoxMateria.Enabled = true;
            }
        }

        public Teste ObterTeste()
        {
            int id = Convert.ToInt32(tbId.Text);
            string nome = TextBoxNome.Text;
            int numeroQuestoes = int.Parse(numericQuestoes.Text);
            bool recuperacao = checkBoxRecuperacao.Checked;
            Disciplina disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;
            Materia materia = (Materia)cbBoxMateria.SelectedItem;
            List<Questao> listaQuestoes = new List<Questao>();

            foreach (var item in listBoxQuestoes.Items)
            {
                Questao questao = item as Questao;

                listaQuestoes.Add(questao);
            }
            DateTime data = DateTime.Now;
            Teste teste = new Teste(nome, numeroQuestoes, disciplina, materia, listaQuestoes, recuperacao, data);

            if (id > 0)
                teste.id = id;

            return teste;
        }
        private void TelaTesteForm_Load(object sender, EventArgs e)
        {
            cbBoxMateria.Enabled = false;
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();
            List<string> ListaErros = teste.ValidarErros();

            if (listBoxQuestoes.Items.Count < 1)
                ListaErros.Add("Número mínimo de questões é 1!");

            if (ListaErros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }
        }
        private void SelecionarQuestao(int quantidade)
        {
            if (questaoDisponivel.Count >= quantidade)
            {
                List<Questao> questoesSorteadas = SortearQuestao(questaoDisponivel, quantidade);
                questoesSorteadas.ForEach(s => listBoxQuestoes.Items.Add(s.enunciado));

                if (questaoDisponivel.Count == 0)
                    MessageBox.Show("Todas as questões já foram selecionadas.");
            }
            else
            {
                MessageBox.Show("Número de questões excede a quantidade cadastrada.");
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {

            listBoxQuestoes.Items.Clear();
            int quantidade = int.Parse(numericQuestoes.Text);
            if (cbBoxDisciplina.SelectedItem != null)
            {

                Disciplina disciplinaSelecionada = (Disciplina)cbBoxDisciplina.SelectedItem;
                SelecionarQuestao(quantidade);
            }
            else if (cbBoxMateria.SelectedItem != null)
            {
                Materia materiaSelecionada = (Materia)cbBoxMateria.SelectedItem;
                SelecionarQuestao(quantidade);
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina primeiro.");
            }
        }

        private List<Questao> SortearQuestao(List<Questao> questaoDisponivel, int quantidade)
        {
            List<Questao> questoesSorteadas = new List<Questao>();

            Random random = new Random();
            List<Questao> listaCopia = new List<Questao>(questaoDisponivel);

            for (int i = 0; i < quantidade; i++)
            {
                int index = random.Next(listaCopia.Count);
                questoesSorteadas.Add(listaCopia[index]);
                listaCopia.RemoveAt(index);
            }

            return questoesSorteadas;
        }

        private void cbBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSelecao();
        }
        private void AtualizarSelecao()
        {
            listBoxQuestoes.Items.Clear();

            Materia materiaSelecionada = (Materia)cbBoxMateria.SelectedItem;

            if (materiaSelecionada != null)
            {
                List<Questao> questoesFiltradas = questaoDisponivel
                    .Where(q => q.materia == materiaSelecionada)
                    .ToList();

                questoesFiltradas.ForEach(q => listBoxQuestoes.Items.Add(q.enunciado));
            }
        }

    }
}
