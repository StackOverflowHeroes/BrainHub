

namespace BrainHub.WinApp.Compartilhado
{
     public abstract class ControladorBase
     {
          public abstract string ToolTipInserir { get; }
          public abstract string ToolTipEditar { get; }
          public abstract string ToolTipDeletar { get; }
          public virtual string ToolTipDuplicar { get { return "Duplicar"; } }
          public virtual string ToolTipVisualizarTeste { get { return "Visualizar"; } }
          public virtual bool InserirHabilitado { get { return false; } }
          public virtual bool EditarHabilitado { get { return false; } }
          public virtual bool DeletarHabilitado { get { return false; } }
          public virtual bool VisualizarTesteHabilitado { get { return false; } }
          public virtual bool DuplicarHabilitado { get { return false; } }

          public abstract void Inserir();

          public abstract void Editar();

          public abstract void Deletar();

          public virtual void Duplicar() { }

          public virtual void VisualizarTeste() { }

          public abstract void CarregarRegistros();

          public abstract UserControl ObterListagem();

          public abstract string ObterTipoCadastro();

     }
}
