

namespace BrainHub.WinApp.Compartilhado
{
    public abstract class ControladorBase
    { 
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipDeletar { get; }
        public virtual bool InserirHabilitado { get; }
        public virtual bool EditarHabilitado { get; }
        public virtual bool DeletarHabilitado { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Deletar();
        

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}
