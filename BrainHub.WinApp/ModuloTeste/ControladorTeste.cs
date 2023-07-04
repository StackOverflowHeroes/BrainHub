using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
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
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl TabelaTeste;

        public ControladorTeste(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioTeste repositorioTeste)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioTeste = repositorioTeste;
        }

        public override string ToolTipInserir => "Inserir teste";
        public override string ToolTipEditar => "Editar teste";
        public override string ToolTipDeletar => "Deletar teste";
        public override bool InserirHabilitado { get { return true; } }
        public override bool EditarHabilitado { get { return true; } }
        public override bool DeletarHabilitado { get { return true; } }

        public override void CarregarRegistros()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            TabelaTeste.AtualizarRegistros(testes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} teste(s)", TipoStatusEnum.Visualizando);
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
