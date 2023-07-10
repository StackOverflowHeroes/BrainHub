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
            RadioButtonGabarito = new RadioButton();
            RadioButtonTeste = new RadioButton();
            botaoGravar = new Button();
            botaoCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonGabarito);
            groupBox1.Controls.Add(RadioButtonTeste);
            groupBox1.Location = new Point(59, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gerar PDF";
            // 
            // RadioButtonGabarito
            // 
            RadioButtonGabarito.AutoSize = true;
            RadioButtonGabarito.Location = new Point(53, 110);
            RadioButtonGabarito.Name = "RadioButtonGabarito";
            RadioButtonGabarito.Size = new Size(240, 24);
            RadioButtonGabarito.TabIndex = 1;
            RadioButtonGabarito.TabStop = true;
            RadioButtonGabarito.Text = "Gerar PDF do gabarito do teste.";
            RadioButtonGabarito.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTeste
            // 
            RadioButtonTeste.AutoSize = true;
            RadioButtonTeste.Location = new Point(53, 63);
            RadioButtonTeste.Name = "RadioButtonTeste";
            RadioButtonTeste.Size = new Size(157, 24);
            RadioButtonTeste.TabIndex = 0;
            RadioButtonTeste.TabStop = true;
            RadioButtonTeste.Text = "Gerar PDF do teste.";
            RadioButtonTeste.UseVisualStyleBackColor = true;
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(226, 251);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(107, 45);
            botaoGravar.TabIndex = 14;
            botaoGravar.Text = "Baixar";
            botaoGravar.UseVisualStyleBackColor = true;
            botaoGravar.Click += GerarPDF_Click;
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
        private RadioButton RadioButtonGabarito;
        private RadioButton RadioButtonTeste;
        private Button botaoGravar;
        private Button botaoCancelar;
    }
}