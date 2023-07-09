namespace BrainHub.WinApp.ModuloTeste
{
    partial class TelaPDFTesteForm
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
            groupBox1 = new GroupBox();
            botaoGravar = new Button();
            botaoCancelar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(59, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gerar PDF";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(226, 251);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(107, 45);
            botaoGravar.TabIndex = 14;
            botaoGravar.Text = "Gerar";
            botaoGravar.UseVisualStyleBackColor = true;
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(349, 251);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(107, 45);
            botaoCancelar.TabIndex = 13;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(53, 63);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Gerar PDF do teste.";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(53, 110);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(240, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gerar PDF do gabarito do teste.";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // TelaPDFTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 329);
            Controls.Add(botaoGravar);
            Controls.Add(groupBox1);
            Controls.Add(botaoCancelar);
            Name = "TelaPDFTesteForm";
            Text = "TelaPDFTesteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button botaoGravar;
        private Button botaoCancelar;
    }
}