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
        private List<Questao> questaoDisponivel;
        private List<Disciplina> ListaCompletaDisciplina;
        private List<Teste> ListaCompletaTeste;

        public TelaTesteForm(List<Disciplina> disciplinas, List<Questao> questoes)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplina(disciplinas);
            this.ListaCompletaDisciplina = disciplinas;
            this.questaoDisponivel = questoes;
        }

        public void CarregarDisciplina(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                cbBoxDisciplina.Items.Add(disciplina);
            }
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cbBoxMateria.Items.Clear();

            foreach (Materia materia in materias)
            {
                cbBoxMateria.Items.Add(materia);
            }
        }

        public void ConfigurarTela(Teste testeSelecionado)
        {
            tbId.Text = testeSelecionado.id.ToString();
            TextBoxNome.Text = testeSelecionado.nome;
            numericQuestoes.Value = testeSelecionado.listaQuestoes.Count;
            cbBoxDisciplina.SelectedItem = testeSelecionado.disciplina;
            cbBoxMateria.SelectedItem = testeSelecionado.materia;

            foreach (Questao q in testeSelecionado.listaQuestoes)
            {
                listBoxQuestoes.Items.Add(q);
            }

            if(testeSelecionado.provaRecuperacao == true)
                checkBoxRecuperacao.Checked = true;
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked)
            {
                cbBoxMateria.Enabled = false;
                listBoxQuestoes.Items.Clear();
                cbBoxMateria.SelectedIndex = -1;
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
            Disciplina disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;
            Materia materia = (Materia)cbBoxMateria.SelectedItem;
            bool provaRecuperacao = checkBoxRecuperacao.Checked;
            List<Questao> listaQuestoes = listBoxQuestoes.Items.Cast<Questao>().ToList();

            DateTime data = DateTime.Now;
            Teste teste = new Teste(nome, numeroQuestoes, disciplina, materia, listaQuestoes, provaRecuperacao, data);

            if (id > 0)
                teste.id = id;

            return teste;
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();
            List<string> ListaErros = teste.ValidarErros();

            if (listBoxQuestoes.Items.Count < 1)
                ListaErros.Add("Número mínimo de questões é 1!");

            if (VerificarNomeDuplicado(teste.nome, teste.id))
                ListaErros.Add("Não é possível cadastrar um teste duas vezes");

            if (ListaErros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }
        }

        private bool VerificarNomeDuplicado(string nome, int id)
        {
            bool NomeDuplicado = ListaCompletaTeste.Any(teste => teste.nome.ToLower() == nome.ToLower() && teste.id != id);

            if (NomeDuplicado)
                return true;
            else
                return false;
        }

        public void ConfigurarDuplicacaoTeste(Teste teste)
        {
            tbId.Text = 0.ToString();
            TextBoxNome.Text = teste.nome;
            numericQuestoes.Value = 1;
            cbBoxDisciplina.SelectedItem = teste.disciplina;
            cbBoxMateria.SelectedItem = teste.materia;
            listBoxQuestoes.Items.Clear();

            if (teste.provaRecuperacao == true)
                checkBoxRecuperacao.Checked = true;
        }

        public void SalvarListaTestes(List<Teste> listaCompletaTeste)
        {
            this.ListaCompletaTeste = listaCompletaTeste;
        }

        private void SelecionarQuestoesMateria(Materia materia, int quantidade)
        {
            if (materia.questoes.Count == 0)
            {
                MessageBox.Show("Número de questões excede a quantidade cadastrada.");
            }

            List<Questao> questoesSorteadas = SortearQuestoesMaterias(materia.questoes, quantidade);
            questoesSorteadas.ForEach(s => listBoxQuestoes.Items.Add(s));
        }

        private void SelecionarQuestoesDisciplina(Disciplina disciplina, int quantidade)
        {
            if (questaoDisponivel.Count >= quantidade)
            {
                // List<Questao> questoesSorteadas = SortearQuestao(quantidade);
                // questoesSorteadas.ForEach(s => listBoxQuestoes.Items.Add(s.enunciado));

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

            if (cbBoxMateria.SelectedItem != null)
            {
                Materia materiaSelecionada = (Materia)cbBoxMateria.SelectedItem;
                SelecionarQuestoesMateria(materiaSelecionada, quantidade);
            }
            else if (cbBoxDisciplina.SelectedItem != null)
            {

                Disciplina disciplinaSelecionada = (Disciplina)cbBoxDisciplina.SelectedItem;
                SelecionarQuestoesDisciplina(disciplinaSelecionada, quantidade);
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina primeiro.");
            }
        }

        //private List<Questao> SortearQuestoesMaterias(List<Questao> ListaQuestoesMateria, int quantidade)
        //{
        //    List<Questao> questoesSorteadas = new List<Questao>();

        //    Random random = new Random();
        //    List<Questao> listaCopia = new List<Questao>(ListaQuestoesMateria);

        //    for (int i = 0; i < quantidade; i++)
        //    {
        //        int index = random.Next(listaCopia.Count);
        //        questoesSorteadas.Add(listaCopia[index]);
        //        listaCopia.RemoveAt(index);
        //    }

        //    return questoesSorteadas;
        //}


        private List<Questao> SortearQuestoesMaterias(List<Questao> ListaQuestoesMateria, int quantidade)
        {
            List<Questao> questoesAleatorias = new List<Questao>();

            while (questoesAleatorias.Count != quantidade)
            {
                int random = new Random().Next(0, ListaQuestoesMateria.Count);
                questoesAleatorias.Add(ListaQuestoesMateria[random]);
            }

            return questoesAleatorias;
        }

        private void cbBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = cbBoxDisciplina.SelectedItem as Disciplina;
            listBoxQuestoes.Items.Clear();
            CarregarMaterias(disciplinaSelecionada.materias);
        }
    }


}

