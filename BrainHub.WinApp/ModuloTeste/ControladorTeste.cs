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
        public override bool InserirHabilitado { get { return true; } }
        public override bool EditarHabilitado { get { return true; } }
        public override bool DeletarHabilitado { get { return true; } }

        

        public override void CarregarRegistros()
        {
            List<Teste> ListaCompletaTestes = repositorioTeste.SelecionarTodos();
            TabelaTeste.AtualizarRegistros(ListaCompletaTestes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaTestes.Count} teste(s)", TipoStatusEnum.Visualizando);
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();
            if(testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                        "Edição de testes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(materias, disciplinas, questoes);
            telaTeste.Text = "Edição de testes";
            telaTeste.ConfigurarTela(testeSelecionado);
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                repositorioTeste.Editar(teste.id, teste);
            }
            CarregarRegistros();
            if(opcaoEscolhida == DialogResult.OK)
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
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            TelaTesteForm telaTeste = new TelaTesteForm(materias, disciplinas, questoes);
            //telaTeste.CarregarMateria(repositorioMateria.SelecionarTodos());
            //telaTeste.CarregarDisciplina(repositorioDisciplina.SelecionarTodos());
            //telaTeste.CarregarQuestoes(repositorioQuestao.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste novoTeste = telaTeste.ObterTeste();
                repositorioTeste.Inserir(novoTeste);
                novoTeste.AtualizarRegistros(novoTeste);
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
    }
}
