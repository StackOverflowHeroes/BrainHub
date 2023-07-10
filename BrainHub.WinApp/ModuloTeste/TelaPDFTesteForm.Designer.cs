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
            button1 = new Button();
            CheckBoxGabarito = new CheckBox();
            label2 = new Label();
            TextBoxCaminho = new TextBox();
            TextBoxTituloTeste = new TextBox();
            label1 = new Label();
            botaoGravar = new Button();
            botaoCancelar = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(CheckBoxGabarito);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TextBoxCaminho);
            groupBox1.Controls.Add(TextBoxTituloTeste);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gerar PDF";
            // 
            // button1
            // 
            button1.Location = new Point(305, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheckBoxGabarito
            // 
            CheckBoxGabarito.AutoSize = true;
            CheckBoxGabarito.Location = new Point(62, 167);
            CheckBoxGabarito.Name = "CheckBoxGabarito";
            CheckBoxGabarito.Size = new Size(180, 24);
            CheckBoxGabarito.TabIndex = 6;
            CheckBoxGabarito.Text = "Gerar PDF do gabarito";
            CheckBoxGabarito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 102);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Diretório arquivo";
            // 
            // TextBoxCaminho
            // 
            TextBoxCaminho.Location = new Point(62, 125);
            TextBoxCaminho.Name = "TextBoxCaminho";
            TextBoxCaminho.ReadOnly = true;
            TextBoxCaminho.Size = new Size(237, 27);
            TextBoxCaminho.TabIndex = 4;
            // 
            // TextBoxTituloTeste
            // 
            TextBoxTituloTeste.Location = new Point(62, 63);
            TextBoxTituloTeste.Name = "TextBoxTituloTeste";
            TextBoxTituloTeste.ReadOnly = true;
            TextBoxTituloTeste.Size = new Size(337, 27);
            TextBoxTituloTeste.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 2;
            label1.Text = "Título";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(306, 307);
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
            botaoCancelar.Location = new Point(429, 307);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(107, 45);
            botaoCancelar.TabIndex = 13;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.CheckFileExists = true;
            // 
            // TelaPDFTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 382);
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
        private Button botaoGravar;
        private Button botaoCancelar;
        private CheckBox CheckBoxGabarito;
        private Label label2;
        private TextBox TextBoxCaminho;
        private TextBox TextBoxTituloTeste;
        private Label label1;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}