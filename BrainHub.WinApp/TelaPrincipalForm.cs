using BrainHub.Dados.Arquivo.ModuloDisciplina;
using BrainHub.Dados.Arquivo.ModuloMateria;
using BrainHub.Dados.Arquivo.ModuloQuestao;
using BrainHub.Dados.Arquivo.ModuloTeste;
using BrainHub.Dados.Banco.ModuloDisciplina;
using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
using BrainHub.WinApp.ModuloDisciplina;
using BrainHub.WinApp.ModuloMateria;
using BrainHub.WinApp.ModuloQuestao;
using BrainHub.WinApp.ModuloTeste;
using PartyManager.WinApp.Compartilhado;
using System.Threading.Tasks;

namespace BrainHub.WinApp
{
     public partial class TelaPrincipalForm : Form
     {
          private ControladorBase controlador;
          private int contadorTemporizador = 5;
          private static ContextoDados contexto = new ContextoDados(carregarDados: true);

          private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
          private IRepositorioMateria repositorioMateria = new RepositorioMateriaEmArquivo(contexto);
          private IRepositorioTeste repositorioTeste = new RepositorioTesteEmArquivo(contexto);
          private IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoEmArquivo(contexto);

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
               temporizador.Interval = 1000;
               temporizador.Tick += Timer_tick;
               telaPrincipal = this;
          }

          public void AtualizarRodape(string mensagem, TipoStatusEnum tipoStatus)
          {
               contadorTemporizador = 5;
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

               if (tipoStatus != TipoStatusEnum.Visualizando)
                    temporizador.Start();
          }

          private void Timer_tick(object? sender, EventArgs e)
          {
               contadorTemporizador--;

               if (contadorTemporizador == 0)
               {
                    TextoRodape.ForeColor = default;
                    TextoRodape.Text = "Status";
                    temporizador.Stop();
               }
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
               controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
               ConfigurarTelaPrincipal(controlador);
          }

          private void Questao_Click(object sender, EventArgs e)
          {
               controlador = new ControladorQuestao(repositorioMateria, repositorioQuestao);
               ConfigurarTelaPrincipal(controlador);
          }

          private void Teste_Click(object sender, EventArgs e)
          {
               controlador = new ControladorTeste(repositorioMateria, repositorioDisciplina, repositorioTeste, repositorioQuestao);
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