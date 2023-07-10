namespace BrainHub.WinApp.ModuloTeste
{
    partial class TelaGabaritoForm
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
            listBoxQuestoes = new ListBox();
            label3 = new Label();
            tbMatéria = new TextBox();
            label2 = new Label();
            tbDisciplina = new TextBox();
            label1 = new Label();
            tbNome = new TextBox();
            botaoCancelar = new Button();
            lista = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lista);
            groupBox1.Controls.Add(listBoxQuestoes);
            groupBox1.Location = new Point(112, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 227);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxQuestoes
            // 
            listBoxQuestoes.Dock = DockStyle.Bottom;
            listBoxQuestoes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxQuestoes.FormattingEnabled = true;
            listBoxQuestoes.ItemHeight = 15;
            listBoxQuestoes.Location = new Point(3, 40);
            listBoxQuestoes.Name = "listBoxQuestoes";
            listBoxQuestoes.Size = new Size(372, 184);
            listBoxQuestoes.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 118);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 41;
            label3.Text = "Matéria";
            // 
            // tbMatéria
            // 
            tbMatéria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbMatéria.Location = new Point(152, 135);
            tbMatéria.Margin = new Padding(3, 2, 3, 2);
            tbMatéria.Name = "tbMatéria";
            tbMatéria.ReadOnly = true;
            tbMatéria.Size = new Size(294, 23);
            tbMatéria.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 39;
            label2.Text = "Disciplina";
            // 
            // tbDisciplina
            // 
            tbDisciplina.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbDisciplina.Location = new Point(152, 84);
            tbDisciplina.Margin = new Padding(3, 2, 3, 2);
            tbDisciplina.Name = "tbDisciplina";
            tbDisciplina.ReadOnly = true;
            tbDisciplina.Size = new Size(294, 23);
            tbDisciplina.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 37;
            label1.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbNome.Location = new Point(152, 36);
            tbNome.Margin = new Padding(3, 2, 3, 2);
            tbNome.Name = "tbNome";
            tbNome.ReadOnly = true;
            tbNome.Size = new Size(294, 23);
            tbNome.TabIndex = 36;
            // 
            // botaoCancelar
            // 
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.Location = new Point(393, 414);
            botaoCancelar.Margin = new Padding(3, 2, 3, 2);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 34);
            botaoCancelar.TabIndex = 35;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            lista.Location = new Point(4, 40);
            lista.Name = "lista";
            lista.Size = new Size(368, 181);
            lista.TabIndex = 1;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // TelaGabaritoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 467);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(tbMatéria);
            Controls.Add(label2);
            Controls.Add(tbDisciplina);
            Controls.Add(label1);
            Controls.Add(tbNome);
            Controls.Add(botaoCancelar);
            Name = "TelaGabaritoForm";
            Text = "TelaGabaritoForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxQuestoes;
        private Label label3;
        private TextBox tbMatéria;
        private Label label2;
        private TextBox tbDisciplina;
        private Label label1;
        private TextBox tbNome;
        private Button botaoCancelar;
        private ListView lista;
    }
}