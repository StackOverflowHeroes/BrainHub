namespace BrainHub.WinApp.ModuloTeste
{
    partial class TelaTesteForm
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
            ComboBoxDisciplina = new ComboBox();
            label3 = new Label();
            botaoGravar = new Button();
            label2 = new Label();
            TextBoxNome = new TextBox();
            label1 = new Label();
            TextBoxId = new TextBox();
            botaoCancelar = new Button();
            RadioButtonPrimeiraSerie = new RadioButton();
            groupBox1 = new GroupBox();
            RadioButtonSegundaSerie = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxDisciplina
            // 
            ComboBoxDisciplina.DisplayMember = "nome";
            ComboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDisciplina.FormattingEnabled = true;
            ComboBoxDisciplina.Location = new Point(253, 198);
            ComboBoxDisciplina.Margin = new Padding(3, 2, 3, 2);
            ComboBoxDisciplina.Name = "ComboBoxDisciplina";
            ComboBoxDisciplina.Size = new Size(294, 23);
            ComboBoxDisciplina.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 181);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 23;
            label3.Text = "Disciplina";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(343, 335);
            botaoGravar.Margin = new Padding(3, 2, 3, 2);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(94, 34);
            botaoGravar.TabIndex = 22;
            botaoGravar.Text = "Gravar";
            botaoGravar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 133);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(253, 151);
            TextBoxNome.Margin = new Padding(3, 2, 3, 2);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(294, 23);
            TextBoxNome.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 82);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(253, 99);
            TextBoxId.Margin = new Padding(3, 2, 3, 2);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(294, 23);
            TextBoxId.TabIndex = 18;
            TextBoxId.Text = "0";
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(451, 335);
            botaoCancelar.Margin = new Padding(3, 2, 3, 2);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 34);
            botaoCancelar.TabIndex = 17;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPrimeiraSerie
            // 
            RadioButtonPrimeiraSerie.AutoSize = true;
            RadioButtonPrimeiraSerie.Location = new Point(24, 27);
            RadioButtonPrimeiraSerie.Margin = new Padding(3, 2, 3, 2);
            RadioButtonPrimeiraSerie.Name = "RadioButtonPrimeiraSerie";
            RadioButtonPrimeiraSerie.Size = new Size(69, 19);
            RadioButtonPrimeiraSerie.TabIndex = 15;
            RadioButtonPrimeiraSerie.TabStop = true;
            RadioButtonPrimeiraSerie.Text = "Primeira";
            RadioButtonPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonSegundaSerie);
            groupBox1.Controls.Add(RadioButtonPrimeiraSerie);
            groupBox1.Location = new Point(253, 224);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(294, 94);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Série";
            // 
            // RadioButtonSegundaSerie
            // 
            RadioButtonSegundaSerie.AutoSize = true;
            RadioButtonSegundaSerie.Location = new Point(24, 50);
            RadioButtonSegundaSerie.Margin = new Padding(3, 2, 3, 2);
            RadioButtonSegundaSerie.Name = "RadioButtonSegundaSerie";
            RadioButtonSegundaSerie.Size = new Size(71, 19);
            RadioButtonSegundaSerie.TabIndex = 16;
            RadioButtonSegundaSerie.TabStop = true;
            RadioButtonSegundaSerie.Text = "Segunda";
            RadioButtonSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 421);
            Controls.Add(ComboBoxDisciplina);
            Controls.Add(label3);
            Controls.Add(botaoGravar);
            Controls.Add(label2);
            Controls.Add(TextBoxNome);
            Controls.Add(label1);
            Controls.Add(TextBoxId);
            Controls.Add(botaoCancelar);
            Controls.Add(groupBox1);
            Name = "TelaTesteForm";
            Text = "TelaTesteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxDisciplina;
        private Label label3;
        private Button botaoGravar;
        private Label label2;
        private TextBox TextBoxNome;
        private Label label1;
        private TextBox TextBoxId;
        private Button botaoCancelar;
        private RadioButton RadioButtonPrimeiraSerie;
        private GroupBox groupBox1;
        private RadioButton RadioButtonSegundaSerie;
    }
}