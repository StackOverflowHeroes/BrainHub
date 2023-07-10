
using BrainHub.Dominio.ModuloTeste;

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

        public void SalvarTesteSelecionado(Teste teste)
        {
            testeSelecionado = teste;
        }

        private void GerarPDF_Click(object sender, EventArgs e)
        {
            TipoPDFEnum tipoPDF;

            if (RadioButtonGabarito.Checked)
                tipoPDF = TipoPDFEnum.PDF_Gabarito;
            else
                tipoPDF = TipoPDFEnum.PDF_Teste;

            GeradorPDF novoPDF = new GeradorPDF();
            novoPDF.tipo = tipoPDF;
            novoPDF.conteudo = testeSelecionado;

            novoPDF.Gerar_PDF();
                
        }
    }
}
