
using BrainHub.Dominio.ModuloTeste;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloTeste
{
    public partial class TelaPDFTesteForm : Form
    {
        private Teste testeSelecionado;

        public TelaPDFTesteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void PopularDialog(Teste teste)
        {
            TextBoxTituloTeste.Text = teste.nome;

            testeSelecionado = teste;
        }

        private void GerarPDF_Click(object sender, EventArgs e)
        {
            TipoPDFEnum tipoPDF;

            if (CheckBoxGabarito.Checked)
                tipoPDF = TipoPDFEnum.PDF_Gabarito;
            else
                tipoPDF = TipoPDFEnum.PDF_Teste;

            if (!ValidarSeEhPossivelBaixar())
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Insira o caminho do PDF!", TipoStatusEnum.Erro);
                return;
            }

            GeradorPDF novoPDF = new GeradorPDF();
            novoPDF.tipo = tipoPDF;
            novoPDF.conteudo = testeSelecionado;
            novoPDF.path = TextBoxCaminho.Text;

            novoPDF.Gerar_PDF();

        }

        private bool ValidarSeEhPossivelBaixar()
        {
            bool EhPossivel = true;

            if (string.IsNullOrEmpty(TextBoxCaminho.Text) || string.IsNullOrWhiteSpace(TextBoxCaminho.Text))
                EhPossivel = false;
            else
                EhPossivel = true;

            return EhPossivel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivos PDF|*.pdf|Todos os Arquivos|*.*";
            saveFileDialog1.Title = "Salvar Arquivo";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog1.FileName;
                TextBoxCaminho.Text = caminhoArquivo;
            }
        }
    }
}
