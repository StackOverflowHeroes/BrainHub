namespace BrainHub.WinApp.ModuloQuestao
{
     partial class TabelaQuestaoControl
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
               TabelaQuestao = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)TabelaQuestao).BeginInit();
               SuspendLayout();
               // 
               // TabelaQuestao
               // 
               TabelaQuestao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               TabelaQuestao.Dock = DockStyle.Fill;
               TabelaQuestao.Location = new Point(0, 0);
               TabelaQuestao.Name = "TabelaQuestao";
               TabelaQuestao.RowTemplate.Height = 25;
               TabelaQuestao.Size = new Size(383, 291);
               TabelaQuestao.TabIndex = 0;
               // 
               // TabelaQuestaoControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(TabelaQuestao);
               Name = "TabelaQuestaoControl";
               Size = new Size(383, 291);
               ((System.ComponentModel.ISupportInitialize)TabelaQuestao).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView TabelaQuestao;
     }
}
