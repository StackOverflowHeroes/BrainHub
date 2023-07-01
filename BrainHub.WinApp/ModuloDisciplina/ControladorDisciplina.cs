
using BrainHub.Dominio.ModuloDisciplina;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl TabelaDisciplina;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir disciplina";
        public override string ToolTipEditar => "Editar disciplina";
        public override string ToolTipDeletar => "Deletar disciplina";

        public override  bool InserirHabilitado { get { return true; } }
        public override  bool EditarHabilitado { get { return true; } }
        public override  bool DeletarHabilitado { get { return true; } }

        public override void Inserir()
        {
            TelaDisciplinaForm TelaDisciplina = new TelaDisciplinaForm();
            TelaDisciplina.ConfigurarTela(repositorioDisciplina.SelecionarTodos());

            if (TelaDisciplina.ShowDialog() == DialogResult.OK)
            {
                Disciplina novaDisciplina = TelaDisciplina.ObterDisciplina();
                repositorioDisciplina.Inserir(novaDisciplina);
            }

                CarregarRegistros();
        }

        public override void Editar()
        {
            TelaDisciplinaForm TelaDisciplina = new TelaDisciplinaForm();
            TelaDisciplina.ConfigurarTela(repositorioDisciplina.SelecionarTodos());

            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
                return;

            TelaDisciplina.PopularDialog(disciplinaSelecionada);

            if (TelaDisciplina.ShowDialog() == DialogResult.OK)
            {
                Disciplina disciplinaEditada = TelaDisciplina.ObterDisciplina();
                repositorioDisciplina.Editar(disciplinaEditada.id, disciplinaEditada);
            }

            CarregarRegistros();
        }

        public override void Deletar()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
                return;

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina {disciplinaSelecionada.nome.ToUpper()}?", "Exclusão de disciplinas",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Deletar(disciplinaSelecionada);
            }

            CarregarRegistros();
        }

        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = TabelaDisciplina.ObterIdSelecionado();
            Disciplina disciplinaSelecionada =  repositorioDisciplina.SelecionarPorId(id);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Exclusão de disciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return null;
            }

            return disciplinaSelecionada;


        }

        public override void CarregarRegistros()
        {
            List<Disciplina> ListaCompletaDisciplina = repositorioDisciplina.SelecionarTodos();
            TabelaDisciplina.AtualizarRegistros(ListaCompletaDisciplina);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaDisciplina.Count} disciplina(s)", TipoStatusEnum.Visualizando);
        }

        public override UserControl ObterListagem()
        {
            if (TabelaDisciplina == null)
                TabelaDisciplina = new TabelaDisciplinaControl();

            CarregarRegistros();
            return TabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de disciplinas";
        }

        

    }
}
