using BrainHub.Dominio.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
using BrainHub.WinApp.ModuloMateria;
using PartyManager.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private TabelaTesteControl TabelaTeste;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioTeste repositorioTeste;



        public ControladorTeste(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioTeste repositorioTeste, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioTeste = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir teste";
        public override string ToolTipEditar => "Editar teste";
        public override string ToolTipDeletar => "Deletar teste";
        public override string ToolTipDuplicar => "Duplicar teste";

        public override string ToolTipVisualizarTeste => "Visualizar teste";
        public override bool InserirHabilitado { get { return true; } }
        public override bool EditarHabilitado { get { return true; } }
        public override bool DeletarHabilitado { get { return true; } }
        public override bool GerarPDFHabilitado { get { return true; } }

        public override bool DuplicarHabilitado { get { return true; } }
        public override bool VisualizarTesteHabilitado { get { return true; } }


        public override void CarregarRegistros()
        {
            List<Teste> ListaCompletaTestes = repositorioTeste.SelecionarTodos();
            TabelaTeste.AtualizarRegistros(ListaCompletaTestes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaTestes.Count} teste(s)", TipoStatusEnum.Visualizando);
        }

        public override void Deletar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Exclusão de Testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o teste {testeSelecionado.nome}?", "Exclusão de Testes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcaoEscolhida == DialogResult.OK)
                repositorioTeste.Deletar(testeSelecionado);

            CarregarRegistros();
            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape($"Teste deletado com sucesso!", TipoStatusEnum.Sucesso);
        }

        public override void Editar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Edição de Testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(disciplinas, questoes);
            telaTeste.SalvarListaTestes(repositorioTeste.SelecionarTodos());
            telaTeste.Text = "Edição de Testes";
            telaTeste.ConfigurarTela(testeSelecionado);
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                repositorioTeste.Editar(teste.id, teste);
            }
            CarregarRegistros();
            if (opcaoEscolhida == DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Teste editado com sucesso!", TipoStatusEnum.Sucesso);
            }
        }

        private Teste ObterTesteSelecionado()
        {
            int id = TabelaTeste.ObterIdSelecionado();
            return repositorioTeste.SelecionarPorId(id);
        }

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(disciplinas, questoes);
            telaTeste.SalvarListaTestes(repositorioTeste.SelecionarTodos());

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste novoTeste = telaTeste.ObterTeste();
                repositorioTeste.Inserir(novoTeste);
            }

            CarregarRegistros();

            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape("Teste inserido com sucesso!", TipoStatusEnum.Sucesso);

        }

        public override UserControl ObterListagem()
        {
            if (TabelaTeste == null)
                TabelaTeste = new TabelaTesteControl();

            CarregarRegistros();
            return TabelaTeste;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de testes";
        }

        public override void Duplicar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Edição de Testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(disciplinas, questoes);
            telaTeste.Text = "Duplicar Teste";
            telaTeste.ConfigurarDuplicacaoTeste(testeSelecionado);
            telaTeste.SalvarListaTestes(repositorioTeste.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                teste.id = 0;
                repositorioTeste.Inserir(teste);
            }
            CarregarRegistros();
            if (opcaoEscolhida == DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Teste editado com sucesso!", TipoStatusEnum.Sucesso);
            }
        }

        public override void VisualizarTeste()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Visualização de Testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            TelaDetalhesTesteForm telaDetalheTeste = new TelaDetalhesTesteForm();
            telaDetalheTeste.ConfigurarTela(testeSelecionado);
            telaDetalheTeste.ShowDialog();
        }

        public override void GerarPDF()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Gerar PDF de Testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            TelaPDFTesteForm TelaPdfTeste = new TelaPDFTesteForm();
            TelaPdfTeste.Text = "Gerar PDF";
            TelaPdfTeste.SalvarTesteSelecionado(testeSelecionado);
            
            if (TelaPdfTeste.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }

        }
    }
}
