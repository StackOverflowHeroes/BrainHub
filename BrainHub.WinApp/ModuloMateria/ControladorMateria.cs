using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.WinApp.ModuloDisciplina;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private TabelaMateriaControl TabelaMateria;
        private IRepositorioMateria repositorioMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria)
        {
            this.repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir matéria";
        public override string ToolTipEditar => "Editar matéria";
        public override string ToolTipDeletar => "Deletar matéria";
        public override bool InserirHabilitado { get { return true; } }
        public override bool EditarHabilitado { get { return true; } }
        public override bool DeletarHabilitado { get { return true; } }
        public override void CarregarRegistros()
        {
            List<Materia> ListaCompletaMateria = repositorioMateria.SelecionarTodos();
            TabelaMateria.AtualizarRegistros(ListaCompletaMateria);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaMateria.Count} matéria(s)", TipoStatusEnum.Visualizando);
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (TabelaMateria == null)
                TabelaMateria = new TabelaMateriaControl();

            CarregarRegistros();
            return TabelaMateria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de matérias";
        }
    }
}
