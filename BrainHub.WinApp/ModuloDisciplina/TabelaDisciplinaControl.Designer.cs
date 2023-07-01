namespace BrainHub.WinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
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
            TabelaDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelaDisciplina).BeginInit();
            SuspendLayout();
            // 
            // TabelaDisciplina
            // 
            TabelaDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaDisciplina.Dock = DockStyle.Fill;
            TabelaDisciplina.Location = new Point(0, 0);
            TabelaDisciplina.Name = "TabelaDisciplina";
            TabelaDisciplina.RowHeadersWidth = 51;
            TabelaDisciplina.RowTemplate.Height = 29;
            TabelaDisciplina.Size = new Size(738, 450);
            TabelaDisciplina.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabelaDisciplina);
            Name = "TabelaDisciplinaControl";
            Size = new Size(738, 450);
            ((System.ComponentModel.ISupportInitialize)TabelaDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelaDisciplina;
    }
}
