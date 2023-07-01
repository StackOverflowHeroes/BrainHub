namespace BrainHub.WinApp.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaoCancelar = new Button();
            TextBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TextBoxNome = new TextBox();
            botaoGravar = new Button();
            SuspendLayout();
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(317, 204);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(108, 46);
            botaoCancelar.TabIndex = 1;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(94, 69);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(331, 27);
            TextBoxId.TabIndex = 2;
            TextBoxId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 46);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 112);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(94, 135);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(331, 27);
            TextBoxNome.TabIndex = 4;
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(193, 204);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(108, 46);
            botaoGravar.TabIndex = 6;
            botaoGravar.Text = "Gravar";
            botaoGravar.UseVisualStyleBackColor = true;
            botaoGravar.Click += Gravar_Click;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 326);
            Controls.Add(botaoGravar);
            Controls.Add(label2);
            Controls.Add(TextBoxNome);
            Controls.Add(label1);
            Controls.Add(TextBoxId);
            Controls.Add(botaoCancelar);
            Name = "TelaDisciplinaForm";
            Text = "TelaDisciplinaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botaoCancelar;
        private TextBox TextBoxId;
        private Label label1;
        private Label label2;
        private TextBox TextBoxNome;
        private Button botaoGravar;
    }
}