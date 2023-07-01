
using BrainHub.Dominio.ModuloDisciplina;

namespace BrainHub.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            TabelaDisciplina.ConfigurarGridSomenteLeitura();
            TabelaDisciplina.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Disciplina> ListaCompletaDisciplina)
        {
            TabelaDisciplina.Rows.Clear();

            foreach (Disciplina registro in ListaCompletaDisciplina)
            {
                TabelaDisciplina.Rows.Add(registro.id, registro.nome.ToUpper());
            }
        }

        public int ObterIdSelecionado()
        {
            if (TabelaDisciplina.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(TabelaDisciplina.SelectedRows[0].Cells["id"].Value);

            return id;
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID",
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText= "NOME"
                }
            };

            TabelaDisciplina.Columns.AddRange(colunas);
        }
    }
}
