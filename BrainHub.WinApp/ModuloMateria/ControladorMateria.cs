using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private TabelaMateriaControl TabelaMateria;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir matéria";
        public override string ToolTipEditar => "Editar matéria";
        public override string ToolTipDeletar => "Deletar matéria";
        public override bool InserirHabilitado { get { return true; } }
        public override bool EditarHabilitado { get { return true; } }
        public override bool DeletarHabilitado { get { return true; } }
        
        public override void Inserir()
        {
            TelaMateriaForm TelaMateria = new TelaMateriaForm();
            TelaMateria.PopularComboBoxDisciplina(repositorioDisciplina.SelecionarTodos());
            TelaMateria.ConfigurarTela(repositorioMateria.SelecionarTodos());

            if (TelaMateria.ShowDialog() == DialogResult.OK)
            {
                Materia novaMateria = TelaMateria.ObterMateria();
                repositorioMateria.Inserir(novaMateria);
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
            List<Materia> ListaCompletaMateria = repositorioMateria.SelecionarTodos();
            TabelaMateria.AtualizarRegistros(ListaCompletaMateria);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {ListaCompletaMateria.Count} matéria(s)", TipoStatusEnum.Visualizando);
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
