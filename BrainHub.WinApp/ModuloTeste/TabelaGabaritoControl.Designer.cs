namespace BrainHub.WinApp.ModuloTeste
{
    partial class TabelaGabaritoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabelaGabarito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelaGabarito).BeginInit();
            SuspendLayout();
            // 
            // TabelaGabarito
            // 
            TabelaGabarito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaGabarito.Dock = DockStyle.Fill;
            TabelaGabarito.Location = new Point(0, 0);
            TabelaGabarito.Margin = new Padding(3, 2, 3, 2);
            TabelaGabarito.Name = "TabelaGabarito";
            TabelaGabarito.RowHeadersWidth = 51;
            TabelaGabarito.RowTemplate.Height = 29;
            TabelaGabarito.Size = new Size(475, 342);
            TabelaGabarito.TabIndex = 2;
            // 
            // TabelaGabaritoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabelaGabarito);
            Name = "TabelaGabaritoControl";
            Size = new Size(475, 342);
            ((System.ComponentModel.ISupportInitialize)TabelaGabarito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelaGabarito;
    }
}
