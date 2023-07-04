namespace BrainHub.WinApp.ModuloTeste
{
    partial class TabelaTesteControl
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
            TabelaTeste = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelaTeste).BeginInit();
            SuspendLayout();
            // 
            // TabelaTeste
            // 
            TabelaTeste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaTeste.Dock = DockStyle.Fill;
            TabelaTeste.Location = new Point(0, 0);
            TabelaTeste.Margin = new Padding(3, 2, 3, 2);
            TabelaTeste.Name = "TabelaTeste";
            TabelaTeste.RowHeadersWidth = 51;
            TabelaTeste.RowTemplate.Height = 29;
            TabelaTeste.Size = new Size(480, 345);
            TabelaTeste.TabIndex = 1;
            // 
            // TabelaTesteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabelaTeste);
            Name = "TabelaTesteControl";
            Size = new Size(480, 345);
            ((System.ComponentModel.ISupportInitialize)TabelaTeste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelaTeste;
    }
}
