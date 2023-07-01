namespace BrainHub.WinApp.ModuloMateria
{
    partial class TabelaMateriaControl
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
            TabelaMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelaMateria).BeginInit();
            SuspendLayout();
            // 
            // TabelaMateria
            // 
            TabelaMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaMateria.Dock = DockStyle.Fill;
            TabelaMateria.Location = new Point(0, 0);
            TabelaMateria.Name = "TabelaMateria";
            TabelaMateria.RowHeadersWidth = 51;
            TabelaMateria.RowTemplate.Height = 29;
            TabelaMateria.Size = new Size(555, 454);
            TabelaMateria.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabelaMateria);
            Name = "TabelaMateriaControl";
            Size = new Size(555, 454);
            ((System.ComponentModel.ISupportInitialize)TabelaMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelaMateria;
    }
}
