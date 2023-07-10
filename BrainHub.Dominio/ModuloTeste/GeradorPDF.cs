
using BrainHub.Dominio.ModuloQuestao;
using PdfSharp.Drawing;
using PdfSharp.Pdf;


namespace BrainHub.Dominio.ModuloTeste
{
    public class GeradorPDF
    {
        public TipoPDFEnum tipo;
        public Teste conteudo;

        private PdfDocument document = new PdfDocument();
        private XGraphics gfx;
        private XFont font;
        private double largura = 40;
        private double altura = 40;
        private const string path = "Compartilhado\\arquivo_teste.pdf";

        public GeradorPDF()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            PdfPage page = document.AddPage();
            gfx = XGraphics.FromPdfPage(page);
            font = new XFont("Arial", 12, XFontStyle.Regular);

        }

        public void Gerar_PDF()
        {
            DesenharCabecalho();
            DesenharCorpo();
            document.Save(path);

        }
        private void DesenharCabecalho()
        {
            gfx.DrawString($"Teste: {conteudo.nome}", font, XBrushes.Black, largura, altura);
            altura += 20;
            gfx.DrawString($"Disciplina: {conteudo.disciplina}", font, XBrushes.Black, largura, altura);
            altura += 20;

            if (conteudo.materia != null)
                gfx.DrawString($"Matéria: {conteudo.materia}", font, XBrushes.Black, largura, altura);
            altura += 40;


        }
        private void DesenharCorpo()
        {
            foreach (Questao questao in conteudo.listaQuestoes)
            {
                font = new XFont("Arial", 11, XFontStyle.Regular);
                gfx.DrawString($"Questão: {questao.enunciado}", font, XBrushes.Black, largura, altura);
                altura += 20;

                foreach (Alternativa alternativa in questao.alternativas)
                {
                    font = new XFont("Arial", 10, XFontStyle.Regular);
                    gfx.DrawString(alternativa.tituloResposta, font, XBrushes.Black, largura, altura);
                    altura += 20;
                }
                altura += 20;
            }
        }



    }
}
