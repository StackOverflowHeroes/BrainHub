
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
        public override string ToolTipEditar => "Editar uma disciplina";
        public override string ToolTipDeletar => "Deletar uma disciplina";

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
            throw new NotImplementedException();
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
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
