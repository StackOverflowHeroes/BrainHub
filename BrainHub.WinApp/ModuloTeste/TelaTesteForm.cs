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
        private List<Materia> materias;

        public TelaTesteForm(List<Disciplina> disciplinas, List<Questao> questoes, List<Materia> materias)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplina(disciplinas);
            this.ListaCompletaDisciplina = disciplinas;
            this.questaoDisponivel = questoes;
            this.materias = materias;
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

        private void cbBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = cbBoxDisciplina.SelectedItem as Disciplina;
            listBoxQuestoes.Items.Clear();
            List<Materia> novaListaMaterias = new List<Materia>();
            foreach(Materia materia in materias)
            {
                if(materia.disciplina.id == disciplinaSelecionada.id)
                {
                    novaListaMaterias.Add(materia);
                }
            }
            CarregarMaterias(novaListaMaterias);
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

        private void btnSortear_Click(object sender, EventArgs e)
        {
            listBoxQuestoes.Items.Clear();
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

            teste.SortearQuestoes();

            foreach(Questao q in teste.listaQuestoes)
            {
                listBoxQuestoes.Items.Add(q);
            }

        }


        
    }


}

