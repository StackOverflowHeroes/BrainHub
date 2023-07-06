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
            numericQuestoes = new NumericUpDown();
            label4 = new Label();
            checkBoxRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            listBoxQuestoes = new ListBox();
            btnSortear = new Button();
            label5 = new Label();
            tbId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbBoxDisciplina
            // 
            cbBoxDisciplina.DisplayMember = "nome";
            cbBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxDisciplina.FormattingEnabled = true;
            cbBoxDisciplina.Location = new Point(52, 115);
            cbBoxDisciplina.Margin = new Padding(3, 2, 3, 2);
            cbBoxDisciplina.Name = "cbBoxDisciplina";
            cbBoxDisciplina.Size = new Size(294, 23);
            cbBoxDisciplina.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 98);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 23;
            label3.Text = "Disciplina";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(301, 480);
            botaoGravar.Margin = new Padding(3, 2, 3, 2);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(94, 34);
            botaoGravar.TabIndex = 22;
            botaoGravar.Text = "Gravar";
            botaoGravar.UseVisualStyleBackColor = true;
            botaoGravar.Click += botaoGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(52, 73);
            TextBoxNome.Margin = new Padding(3, 2, 3, 2);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(443, 23);
            TextBoxNome.TabIndex = 20;
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(401, 480);
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
            cbBoxMateria.Location = new Point(52, 157);
            cbBoxMateria.Margin = new Padding(3, 2, 3, 2);
            cbBoxMateria.Name = "cbBoxMateria";
            cbBoxMateria.Size = new Size(294, 23);
            cbBoxMateria.TabIndex = 27;
            cbBoxMateria.SelectedIndexChanged += cbBoxMateria_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 140);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 26;
            label1.Text = "Matéria";
            // 
            // numericQuestoes
            // 
            numericQuestoes.Location = new Point(352, 116);
            numericQuestoes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuestoes.Name = "numericQuestoes";
            numericQuestoes.ReadOnly = true;
            numericQuestoes.Size = new Size(76, 23);
            numericQuestoes.TabIndex = 28;
            numericQuestoes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 98);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 29;
            label4.Text = "Qtd. Questões";
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Location = new Point(352, 157);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(143, 19);
            checkBoxRecuperacao.TabIndex = 31;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            checkBoxRecuperacao.CheckedChanged += checkBoxRecuperacao_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxQuestoes);
            groupBox1.Location = new Point(52, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 227);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxQuestoes
            // 
            listBoxQuestoes.FormattingEnabled = true;
            listBoxQuestoes.ItemHeight = 15;
            listBoxQuestoes.Location = new Point(0, 39);
            listBoxQuestoes.Name = "listBoxQuestoes";
            listBoxQuestoes.Size = new Size(443, 184);
            listBoxQuestoes.TabIndex = 0;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(52, 473);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(104, 41);
            btnSortear.TabIndex = 0;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 13);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 35;
            label5.Text = "Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(52, 30);
            tbId.Margin = new Padding(3, 2, 3, 2);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(443, 23);
            tbId.TabIndex = 34;
            tbId.Text = "0";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 543);
            Controls.Add(label5);
            Controls.Add(tbId);
            Controls.Add(btnSortear);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxRecuperacao);
            Controls.Add(label4);
            Controls.Add(numericQuestoes);
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
            Load += TelaTesteForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuestoes).EndInit();
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
        private NumericUpDown numericQuestoes;
        private Label label4;
        private CheckBox checkBoxRecuperacao;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private Button btnSortear;
        private ListBox listBoxQuestoes;
        private Label label5;
        private TextBox tbId;
    }
}