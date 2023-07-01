using BrainHub.Dados.Arquivo.ModuloDisciplina;
using BrainHub.Dados.Arquivo.ModuloMateria;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.WinApp.ModuloDisciplina;
using BrainHub.WinApp.ModuloMateria;
using PartyManager.WinApp.Compartilhado;

namespace BrainHub.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private static ContextoDados contexto = new ContextoDados(carregarDados: true);

        private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
        private IRepositorioMateria repositorioMateria = new RepositorioMateriaEmArquivo(contexto);


        private static TelaPrincipalForm telaPrincipal;
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        public void AtualizarRodape(string mensagem, TipoStatusEnum tipoStatus)
        {
            Color cor = default;
            switch (tipoStatus)
            {
                case TipoStatusEnum.Nenhum: break;
                case TipoStatusEnum.Erro: cor = Color.Red; break;
                case TipoStatusEnum.Sucesso: cor = Color.Green; break;
                case TipoStatusEnum.Visualizando: cor = Color.Blue; break;
            }

            TextoRodape.ForeColor = cor;
            TextoRodape.Text = mensagem;

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnDeletar.ToolTipText = controlador.ToolTipDeletar;
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarEstadosBotoes(controlador);
        }

        private void ConfigurarListas(ControladorBase controladorBase)
        {
            UserControl listas = controladorBase.ObterListagem();
            listas.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listas);
        }

        private void ConfigurarEstadosBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnDeletar.Enabled = controlador.DeletarHabilitado;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            tslTipoCadastros.Text = controlador.ObterTipoCadastro();
            ConfigurarBarraFerramentas(controladorBase);
            ConfigurarListas(controladorBase);
        }

        private void Disciplina_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void Materia_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria);
            ConfigurarTelaPrincipal(controlador);
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            controlador.Deletar();
        }

       
    }
}