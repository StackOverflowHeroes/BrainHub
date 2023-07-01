
using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private List<Materia> ListaCompletaMateria;
        public TelaMateriaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(TextBoxId.Text);
            string nome = TextBoxNome.Text;
            Disciplina disciplina = ComboBoxDisciplina.SelectedItem as Disciplina;
            SerieEnum serie = ObterSerieDaMateria();

            Materia materia = new Materia(id, nome, disciplina, serie);

            if (id > 0)
                materia.id = id;

            return materia;
        }

        private SerieEnum ObterSerieDaMateria()
        {
            if (RadioButtonPrimeiraSerie.Checked)
                return SerieEnum.primeiraSerie;
            else return SerieEnum.segundaSerie;
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            Materia novaMateria = ObterMateria();

            List<string> ListaErros = novaMateria.ValidarErros();

            if (VerificarNomeDuplicado(novaMateria.nome))
                ListaErros.Add("Não é possível cadastrar uma disciplina duas vezes");

            if (ListaErros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

        }

        public void PopularDialog(Materia materia)
        {
            TextBoxId.Text = materia.id.ToString();
            TextBoxNome.Text = materia.nome;
            ComboBoxDisciplina.SelectedItem = materia.disciplina;

            if (materia.serie == SerieEnum.primeiraSerie)
                RadioButtonPrimeiraSerie.Checked = true;
            else RadioButtonSegundaSerie.Checked = false;

        }

        public void PopularComboBoxDisciplina(List<Disciplina> ListaCompletaDisciplina)
        {
            foreach (Disciplina item in ListaCompletaDisciplina)
            {
                ComboBoxDisciplina.Items.Add(item);
            }
        }

        public void ConfigurarTela(List<Materia> ListaCompleta)
        {
            ListaCompletaMateria = ListaCompleta;
        }

        private bool VerificarNomeDuplicado(string nome)
        {
            bool NomeDuplicado = ListaCompletaMateria.Any(materia => materia.nome.ToLower() == nome.ToLower());

            if (NomeDuplicado)
                return true;
            else
                return false;
        }
    }
}
