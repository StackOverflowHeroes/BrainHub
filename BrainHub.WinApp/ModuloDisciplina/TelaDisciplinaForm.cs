
using BrainHub.Dominio.ModuloDisciplina;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private List<Disciplina> ListaCompletaDisciplina;
        public TelaDisciplinaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(TextBoxId.Text);
            string nome = TextBoxNome.Text;

            Disciplina disciplina = new Disciplina(id, nome);

            if (id > 0)
                disciplina.id = id;

            return disciplina;
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina = ObterDisciplina();

            List<string> ListaErros = novaDisciplina.ValidarErros();

            if (VerificarNomeDuplicado(novaDisciplina.nome))
                ListaErros.Add("Não é possível cadastrar uma disciplina duas vezes");

            if (ListaErros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(ListaErros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

        }

        public void PopularDialog(Disciplina disciplina)
        {
            TextBoxId.Text = disciplina.id.ToString();
            TextBoxNome.Text = disciplina.nome.ToString();
        }     

        public void ConfigurarTela(List<Disciplina> ListaCompleta)
        {
            ListaCompletaDisciplina = ListaCompleta;
        }

        private bool VerificarNomeDuplicado(string nome)
        {
            bool NomeDuplicado = ListaCompletaDisciplina.Any(disciplina => disciplina.nome.ToLower() == nome.ToLower());

            if (NomeDuplicado)
                return true;
            else
                return false;
        }

    }
}
