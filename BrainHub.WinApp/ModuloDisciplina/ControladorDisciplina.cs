
namespace BrainHub.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl TabelaDisciplina;

        public override string ToolTipInserir => "Inserir disciplina";
        public override string ToolTipEditar => "Editar uma disciplina";
        public override string ToolTipDeletar => "Deletar uma disciplina";

        public override  bool InserirHabilitado { get { return true; } }
        public override  bool EditarHabilitado { get { return true; } }
        public override  bool DeletarHabilitado { get { return true; } }

        public override void Inserir()
        {
            throw new NotImplementedException();
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

        private bool VerificarNomeDuplicado(string nome) { return false; }

    }
}
