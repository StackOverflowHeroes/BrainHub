
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
        private string path = "";

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
            PegarPathArquivo();
            document.Save(path);

        }

        private void PegarPathArquivo()
        {
            if (tipo == TipoPDFEnum.PDF_Teste)
                path = "Compartilhado\\MeuTeste.pdf";
            else
                path = "Compartilhado\\MeuTesteGabarito.pdf";
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

            int contador = 1;

            foreach (Questao questao in conteudo.listaQuestoes)
            {
                font = new XFont("Arial", 11, XFontStyle.Regular);

                gfx.DrawString($"QUESTÃO {contador}: {Capitalize(questao.enunciado)}?", font, XBrushes.Black, largura, altura);
                altura += 20;

                foreach (Alternativa alternativa in questao.alternativas)
                {
                    font = new XFont("Arial", 10, XFontStyle.Regular);

                    if (tipo == TipoPDFEnum.PDF_Gabarito && alternativa.alternativaCorreta)
                    {
                        XFont fontAlternativaCorreta = new XFont("Arial", 12, XFontStyle.Bold);
                        gfx.DrawString("X", fontAlternativaCorreta, XBrushes.Green, largura, altura);
                    }

                    gfx.DrawString($"{alternativa.letraAlternativa.ToLower()} )", font, XBrushes.Black, largura, altura);

                    double x = largura;

                    if (tipo == TipoPDFEnum.PDF_Gabarito && alternativa.alternativaCorreta)
                    {
                        XFont fontAlternativaCorreta = new XFont("Arial", 10, XFontStyle.Bold);
                        gfx.DrawString(Capitalize(alternativa.tituloResposta), fontAlternativaCorreta, XBrushes.Green, x + 20, altura);
                    }
                    else
                        gfx.DrawString(Capitalize(alternativa.tituloResposta), font, XBrushes.Black, x + 20, altura);

                    altura += 20;
                }

                altura += 20;
                contador++;
            }
        }

        private string Capitalize(string enunciado)
        {
            string primeiraLetra = enunciado.Substring(0, 1).ToUpper();
            string restoEnunciado = enunciado.Substring(1).ToLower();

            return primeiraLetra + restoEnunciado;
        }


    }
}
