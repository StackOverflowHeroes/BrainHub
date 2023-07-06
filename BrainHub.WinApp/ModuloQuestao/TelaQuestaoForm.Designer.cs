namespace BrainHub.WinApp.ModuloQuestao
{
     partial class TelaQuestaoForm
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
               ComboBoxMateria = new ComboBox();
               label3 = new Label();
               label2 = new Label();
               TextBoxEnunciado = new TextBox();
               label4 = new Label();
               TextBoxResposta = new TextBox();
               botaoAdicionar = new Button();
               botaoGravar = new Button();
               botaoCancelar = new Button();
               GBoxAlternativas = new GroupBox();
               CLBoxAlternativa = new CheckedListBox();
               botaoRemover = new Button();
               label1 = new Label();
               TextBoxId = new TextBox();
               GBoxAlternativas.SuspendLayout();
               SuspendLayout();
               // 
               // ComboBoxMateria
               // 
               ComboBoxMateria.DisplayMember = "nome";
               ComboBoxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
               ComboBoxMateria.FormattingEnabled = true;
               ComboBoxMateria.Location = new Point(72, 95);
               ComboBoxMateria.Margin = new Padding(3, 2, 3, 2);
               ComboBoxMateria.Name = "ComboBoxMateria";
               ComboBoxMateria.Size = new Size(294, 23);
               ComboBoxMateria.TabIndex = 18;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Location = new Point(72, 78);
               label3.Name = "label3";
               label3.Size = new Size(47, 15);
               label3.TabIndex = 17;
               label3.Text = "Matéria";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(72, 120);
               label2.Name = "label2";
               label2.Size = new Size(63, 15);
               label2.TabIndex = 16;
               label2.Text = "Enunciado";
               // 
               // TextBoxEnunciado
               // 
               TextBoxEnunciado.Location = new Point(72, 138);
               TextBoxEnunciado.Margin = new Padding(3, 2, 3, 2);
               TextBoxEnunciado.Multiline = true;
               TextBoxEnunciado.Name = "TextBoxEnunciado";
               TextBoxEnunciado.Size = new Size(294, 58);
               TextBoxEnunciado.TabIndex = 15;
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Location = new Point(72, 198);
               label4.Name = "label4";
               label4.Size = new Size(54, 15);
               label4.TabIndex = 20;
               label4.Text = "Resposta";
               // 
               // TextBoxResposta
               // 
               TextBoxResposta.Location = new Point(72, 216);
               TextBoxResposta.Margin = new Padding(3, 2, 3, 2);
               TextBoxResposta.Multiline = true;
               TextBoxResposta.Name = "TextBoxResposta";
               TextBoxResposta.Size = new Size(222, 34);
               TextBoxResposta.TabIndex = 19;
               // 
               // botaoAdicionar
               // 
               botaoAdicionar.Location = new Point(300, 216);
               botaoAdicionar.Margin = new Padding(3, 2, 3, 2);
               botaoAdicionar.Name = "botaoAdicionar";
               botaoAdicionar.Size = new Size(66, 34);
               botaoAdicionar.TabIndex = 21;
               botaoAdicionar.Text = "Adicionar";
               botaoAdicionar.UseVisualStyleBackColor = true;
               botaoAdicionar.Click += botaoAdicionar_Click;
               // 
               // botaoGravar
               // 
               botaoGravar.DialogResult = DialogResult.OK;
               botaoGravar.Location = new Point(172, 399);
               botaoGravar.Margin = new Padding(3, 2, 3, 2);
               botaoGravar.Name = "botaoGravar";
               botaoGravar.Size = new Size(94, 34);
               botaoGravar.TabIndex = 22;
               botaoGravar.Text = "Gravar";
               botaoGravar.UseVisualStyleBackColor = true;
               botaoGravar.Click += botaoGravar_Click;
               // 
               // botaoCancelar
               // 
               botaoCancelar.DialogResult = DialogResult.Cancel;
               botaoCancelar.Location = new Point(272, 399);
               botaoCancelar.Margin = new Padding(3, 2, 3, 2);
               botaoCancelar.Name = "botaoCancelar";
               botaoCancelar.Size = new Size(94, 34);
               botaoCancelar.TabIndex = 23;
               botaoCancelar.Text = "Cancelar";
               botaoCancelar.UseVisualStyleBackColor = true;
               // 
               // GBoxAlternativas
               // 
               GBoxAlternativas.Controls.Add(CLBoxAlternativa);
               GBoxAlternativas.Controls.Add(botaoRemover);
               GBoxAlternativas.Location = new Point(72, 256);
               GBoxAlternativas.Name = "GBoxAlternativas";
               GBoxAlternativas.Size = new Size(294, 138);
               GBoxAlternativas.TabIndex = 24;
               GBoxAlternativas.TabStop = false;
               GBoxAlternativas.Text = "Alternativas";
               // 
               // CLBoxAlternativa
               // 
               CLBoxAlternativa.CheckOnClick = true;
               CLBoxAlternativa.Dock = DockStyle.Bottom;
               CLBoxAlternativa.FormattingEnabled = true;
               CLBoxAlternativa.Location = new Point(3, 41);
               CLBoxAlternativa.Name = "CLBoxAlternativa";
               CLBoxAlternativa.Size = new Size(288, 94);
               CLBoxAlternativa.TabIndex = 23;
               CLBoxAlternativa.ItemCheck += CheckedListBox_ItemCheck;
               // 
               // botaoRemover
               // 
               botaoRemover.Location = new Point(225, 14);
               botaoRemover.Margin = new Padding(3, 2, 3, 2);
               botaoRemover.Name = "botaoRemover";
               botaoRemover.Size = new Size(66, 22);
               botaoRemover.TabIndex = 22;
               botaoRemover.Text = "Remover";
               botaoRemover.UseVisualStyleBackColor = true;
               botaoRemover.Click += botaoRemover_Click;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(72, 36);
               label1.Name = "label1";
               label1.Size = new Size(17, 15);
               label1.TabIndex = 26;
               label1.Text = "Id";
               // 
               // TextBoxId
               // 
               TextBoxId.Location = new Point(72, 53);
               TextBoxId.Margin = new Padding(3, 2, 3, 2);
               TextBoxId.Name = "TextBoxId";
               TextBoxId.ReadOnly = true;
               TextBoxId.Size = new Size(294, 23);
               TextBoxId.TabIndex = 25;
               TextBoxId.Text = "0";
               // 
               // TelaQuestaoForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(434, 461);
               Controls.Add(label1);
               Controls.Add(TextBoxId);
               Controls.Add(GBoxAlternativas);
               Controls.Add(botaoCancelar);
               Controls.Add(botaoGravar);
               Controls.Add(botaoAdicionar);
               Controls.Add(label4);
               Controls.Add(TextBoxResposta);
               Controls.Add(ComboBoxMateria);
               Controls.Add(label3);
               Controls.Add(label2);
               Controls.Add(TextBoxEnunciado);
               Name = "TelaQuestaoForm";
               Text = "Cadastro de Questão";
               GBoxAlternativas.ResumeLayout(false);
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion
          private ComboBox ComboBoxMateria;
          private Label label3;
          private Label label2;
          private TextBox TextBoxEnunciado;
          private Label label4;
          private TextBox TextBoxResposta;
          private Button botaoAdicionar;
          private Button botaoGravar;
          private Button botaoCancelar;
          private GroupBox GBoxAlternativas;
          private Button botaoRemover;
          private CheckedListBox CLBoxAlternativa;
          private Label label1;
          private TextBox TextBoxId;
     }
}