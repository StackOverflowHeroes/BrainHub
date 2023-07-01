using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.WinApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            TabelaMateria.ConfigurarGridSomenteLeitura();
            TabelaMateria.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Materia> ListaCompletaDMateria)
        {
            TabelaMateria.Rows.Clear();

            foreach (Materia registro in ListaCompletaDMateria)
            {
                string nomeDisciplina = registro.disciplina.nome.ToUpper();

                TabelaMateria.Rows.Add(registro.id, registro.nome.ToUpper(), nomeDisciplina, registro.serie);
            }
        }

        public int ObterIdSelecionado()
        {
            if (TabelaMateria.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(TabelaMateria.SelectedRows[0].Cells["id"].Value);

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
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText= "DISCIPLINA"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "serie",
                    HeaderText= "SÉRIE"
                },
            };

            TabelaMateria.Columns.AddRange(colunas);
        }
    }
}
