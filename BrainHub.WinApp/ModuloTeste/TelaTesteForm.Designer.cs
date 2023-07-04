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
            cbBoxDisciplina = new ComboBox();
            label3 = new Label();
            botaoGravar = new Button();
            label2 = new Label();
            TextBoxNome = new TextBox();
            botaoCancelar = new Button();
            cbBoxMateria = new ComboBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            btnSortear = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbBoxDisciplina
            // 
            cbBoxDisciplina.DisplayMember = "nome";
            cbBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxDisciplina.FormattingEnabled = true;
            cbBoxDisciplina.Location = new Point(55, 105);
            cbBoxDisciplina.Margin = new Padding(3, 2, 3, 2);
            cbBoxDisciplina.Name = "cbBoxDisciplina";
            cbBoxDisciplina.Size = new Size(294, 23);
            cbBoxDisciplina.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 23;
            label3.Text = "Disciplina";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(304, 490);
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
            label2.Location = new Point(55, 40);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(55, 58);
            TextBoxNome.Margin = new Padding(3, 2, 3, 2);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(443, 23);
            TextBoxNome.TabIndex = 20;
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(404, 490);
            botaoCancelar.Margin = new Padding(3, 2, 3, 2);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 34);
            botaoCancelar.TabIndex = 17;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // cbBoxMateria
            // 
            cbBoxMateria.DisplayMember = "nome";
            cbBoxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxMateria.FormattingEnabled = true;
            cbBoxMateria.Location = new Point(55, 172);
            cbBoxMateria.Margin = new Padding(3, 2, 3, 2);
            cbBoxMateria.Name = "cbBoxMateria";
            cbBoxMateria.Size = new Size(294, 23);
            cbBoxMateria.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 155);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 26;
            label1.Text = "Matéria";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(355, 106);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 23);
            numericUpDown1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 83);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 29;
            label4.Text = "Qtd. Questões";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(355, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Prova de Recuperação";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(55, 133);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(55, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 199);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(55, 483);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(104, 41);
            btnSortear.TabIndex = 0;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(443, 154);
            listBox1.TabIndex = 0;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 543);
            Controls.Add(btnSortear);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(cbBoxMateria);
            Controls.Add(label1);
            Controls.Add(cbBoxDisciplina);
            Controls.Add(label3);
            Controls.Add(botaoGravar);
            Controls.Add(label2);
            Controls.Add(TextBoxNome);
            Controls.Add(botaoCancelar);
            Name = "TelaTesteForm";
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBoxDisciplina;
        private Label label3;
        private Button botaoGravar;
        private Label label2;
        private TextBox TextBoxNome;
        private Button botaoCancelar;
        private ComboBox cbBoxMateria;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private Button btnSortear;
        private ListBox listBox1;
    }
}