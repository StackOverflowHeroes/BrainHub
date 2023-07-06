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
            cbBoxDisciplina.Location = new Point(59, 153);
            cbBoxDisciplina.Name = "cbBoxDisciplina";
            cbBoxDisciplina.Size = new Size(335, 28);
            cbBoxDisciplina.TabIndex = 24;
            cbBoxDisciplina.SelectedIndexChanged += cbBoxDisciplina_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 131);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 23;
            label3.Text = "Disciplina";
            // 
            // botaoGravar
            // 
            botaoGravar.DialogResult = DialogResult.OK;
            botaoGravar.Location = new Point(344, 640);
            botaoGravar.Name = "botaoGravar";
            botaoGravar.Size = new Size(107, 45);
            botaoGravar.TabIndex = 22;
            botaoGravar.Text = "Gravar";
            botaoGravar.UseVisualStyleBackColor = true;
            botaoGravar.Click += botaoGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(59, 97);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(506, 27);
            TextBoxNome.TabIndex = 20;
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(458, 640);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(107, 45);
            botaoCancelar.TabIndex = 17;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // cbBoxMateria
            // 
            cbBoxMateria.DisplayMember = "nome";
            cbBoxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxMateria.Enabled = false;
            cbBoxMateria.FormattingEnabled = true;
            cbBoxMateria.Location = new Point(59, 209);
            cbBoxMateria.Name = "cbBoxMateria";
            cbBoxMateria.Size = new Size(335, 28);
            cbBoxMateria.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 187);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 26;
            label1.Text = "Matéria";
            // 
            // numericQuestoes
            // 
            numericQuestoes.Location = new Point(402, 155);
            numericQuestoes.Margin = new Padding(3, 4, 3, 4);
            numericQuestoes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuestoes.Name = "numericQuestoes";
            numericQuestoes.ReadOnly = true;
            numericQuestoes.Size = new Size(87, 27);
            numericQuestoes.TabIndex = 28;
            numericQuestoes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 131);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 29;
            label4.Text = "Qtd. Questões";
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Location = new Point(402, 209);
            checkBoxRecuperacao.Margin = new Padding(3, 4, 3, 4);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(179, 24);
            checkBoxRecuperacao.TabIndex = 31;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            checkBoxRecuperacao.CheckedChanged += checkBoxRecuperacao_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxQuestoes);
            groupBox1.Location = new Point(59, 281);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(506, 303);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxQuestoes
            // 
            listBoxQuestoes.FormattingEnabled = true;
            listBoxQuestoes.ItemHeight = 20;
            listBoxQuestoes.Location = new Point(0, 52);
            listBoxQuestoes.Margin = new Padding(3, 4, 3, 4);
            listBoxQuestoes.Name = "listBoxQuestoes";
            listBoxQuestoes.Size = new Size(506, 244);
            listBoxQuestoes.TabIndex = 0;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(59, 631);
            btnSortear.Margin = new Padding(3, 4, 3, 4);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(119, 55);
            btnSortear.TabIndex = 0;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 17);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 35;
            label5.Text = "Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(59, 40);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(506, 27);
            tbId.TabIndex = 34;
            tbId.Text = "0";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 724);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaTesteForm";
            Text = "Cadastro de Testes";
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