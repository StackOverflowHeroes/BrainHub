namespace BrainHub.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            botaoGravar = new Button();
            label2 = new Label();
            TextBoxNome = new TextBox();
            label1 = new Label();
            TextBoxId = new TextBox();
            botaoCancelar = new Button();
            label3 = new Label();
            ComboBoxDisciplina = new ComboBox();
            RadioButtonPrimeiraSerie = new RadioButton();
            groupBox1 = new GroupBox();
            RadioButtonSegundaSerie = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(179, 400);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(108, 46);
            botaoGravar.TabIndex = 12;
            botaoGravar.Text = "Gravar";
            botaoGravar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 131);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(77, 154);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(336, 27);
            TextBoxNome.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 63);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(77, 86);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(336, 27);
            TextBoxId.TabIndex = 8;
            TextBoxId.Text = "0";
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(303, 400);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(108, 46);
            botaoCancelar.TabIndex = 7;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 194);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Disciplina";
            // 
            // ComboBoxDisciplina
            // 
            ComboBoxDisciplina.DisplayMember = "nome";
            ComboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDisciplina.FormattingEnabled = true;
            ComboBoxDisciplina.Location = new Point(77, 217);
            ComboBoxDisciplina.Name = "ComboBoxDisciplina";
            ComboBoxDisciplina.Size = new Size(336, 28);
            ComboBoxDisciplina.TabIndex = 14;
            // 
            // RadioButtonPrimeiraSerie
            // 
            RadioButtonPrimeiraSerie.AutoSize = true;
            RadioButtonPrimeiraSerie.Location = new Point(28, 38);
            RadioButtonPrimeiraSerie.Name = "RadioButtonPrimeiraSerie";
            RadioButtonPrimeiraSerie.Size = new Size(85, 24);
            RadioButtonPrimeiraSerie.TabIndex = 15;
            RadioButtonPrimeiraSerie.TabStop = true;
            RadioButtonPrimeiraSerie.Text = "Primeira";
            RadioButtonPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonSegundaSerie);
            groupBox1.Controls.Add(RadioButtonPrimeiraSerie);
            groupBox1.Location = new Point(77, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 125);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Série";
            // 
            // RadioButtonSegundaSerie
            // 
            RadioButtonSegundaSerie.AutoSize = true;
            RadioButtonSegundaSerie.Location = new Point(28, 68);
            RadioButtonSegundaSerie.Name = "RadioButtonSegundaSerie";
            RadioButtonSegundaSerie.Size = new Size(88, 24);
            RadioButtonSegundaSerie.TabIndex = 16;
            RadioButtonSegundaSerie.TabStop = true;
            RadioButtonSegundaSerie.Text = "Segunda";
            RadioButtonSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 496);
            Controls.Add(groupBox1);
            Controls.Add(ComboBoxDisciplina);
            Controls.Add(label3);
            Controls.Add(botaoGravar);
            Controls.Add(label2);
            Controls.Add(TextBoxNome);
            Controls.Add(label1);
            Controls.Add(TextBoxId);
            Controls.Add(botaoCancelar);
            Name = "TelaMateriaForm";
            Text = "TelaMateriaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoGravar;
        private Label label2;
        private TextBox TextBoxNome;
        private Label label1;
        private TextBox TextBoxId;
        private Button botaoCancelar;
        private Label label3;
        private ComboBox ComboBoxDisciplina;
        private RadioButton RadioButtonPrimeiraSerie;
        private GroupBox groupBox1;
        private RadioButton RadioButtonSegundaSerie;
    }
}