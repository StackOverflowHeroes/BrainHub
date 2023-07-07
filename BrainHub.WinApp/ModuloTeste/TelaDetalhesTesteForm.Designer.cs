namespace BrainHub.WinApp.ModuloTeste
{
     partial class TelaDetalhesTesteForm
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
               label1 = new Label();
               TextBoxTitulo = new TextBox();
               label2 = new Label();
               TextBoxDisciplina = new TextBox();
               label3 = new Label();
               TextBoxMatéria = new TextBox();
               groupBox1 = new GroupBox();
               listBoxQuestoes = new ListBox();
               botaoCancelar = new Button();
               groupBox1.SuspendLayout();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(69, 31);
               label1.Name = "label1";
               label1.Size = new Size(40, 15);
               label1.TabIndex = 28;
               label1.Text = "Nome";
               // 
               // TextBoxTitulo
               // 
               TextBoxTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
               TextBoxTitulo.Location = new Point(69, 48);
               TextBoxTitulo.Margin = new Padding(3, 2, 3, 2);
               TextBoxTitulo.Name = "TextBoxTitulo";
               TextBoxTitulo.ReadOnly = true;
               TextBoxTitulo.Size = new Size(294, 23);
               TextBoxTitulo.TabIndex = 27;
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(69, 79);
               label2.Name = "label2";
               label2.Size = new Size(58, 15);
               label2.TabIndex = 30;
               label2.Text = "Disciplina";
               // 
               // TextBoxDisciplina
               // 
               TextBoxDisciplina.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
               TextBoxDisciplina.Location = new Point(69, 96);
               TextBoxDisciplina.Margin = new Padding(3, 2, 3, 2);
               TextBoxDisciplina.Name = "TextBoxDisciplina";
               TextBoxDisciplina.ReadOnly = true;
               TextBoxDisciplina.Size = new Size(294, 23);
               TextBoxDisciplina.TabIndex = 29;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Location = new Point(69, 130);
               label3.Name = "label3";
               label3.Size = new Size(47, 15);
               label3.TabIndex = 32;
               label3.Text = "Matéria";
               // 
               // TextBoxMatéria
               // 
               TextBoxMatéria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
               TextBoxMatéria.Location = new Point(69, 147);
               TextBoxMatéria.Margin = new Padding(3, 2, 3, 2);
               TextBoxMatéria.Name = "TextBoxMatéria";
               TextBoxMatéria.ReadOnly = true;
               TextBoxMatéria.Size = new Size(294, 23);
               TextBoxMatéria.TabIndex = 31;
               // 
               // groupBox1
               // 
               groupBox1.Controls.Add(listBoxQuestoes);
               groupBox1.Location = new Point(29, 184);
               groupBox1.Name = "groupBox1";
               groupBox1.Size = new Size(378, 227);
               groupBox1.TabIndex = 34;
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
               // botaoCancelar
               // 
               botaoCancelar.DialogResult = DialogResult.Cancel;
               botaoCancelar.Location = new Point(310, 426);
               botaoCancelar.Margin = new Padding(3, 2, 3, 2);
               botaoCancelar.Name = "botaoCancelar";
               botaoCancelar.Size = new Size(94, 34);
               botaoCancelar.TabIndex = 24;
               botaoCancelar.Text = "Cancelar";
               botaoCancelar.UseVisualStyleBackColor = true;
               // 
               // TelaDetalhesTesteForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(434, 471);
               Controls.Add(botaoCancelar);
               Controls.Add(groupBox1);
               Controls.Add(label3);
               Controls.Add(TextBoxMatéria);
               Controls.Add(label2);
               Controls.Add(TextBoxDisciplina);
               Controls.Add(label1);
               Controls.Add(TextBoxTitulo);
               Name = "TelaDetalhesTesteForm";
               Text = "Visualização de Detalhes do Teste";
               groupBox1.ResumeLayout(false);
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private TextBox TextBoxTitulo;
          private Label label2;
          private TextBox TextBoxDisciplina;
          private Label label3;
          private TextBox TextBoxMatéria;
          private GroupBox groupBox1;
          private ListBox listBoxQuestoes;
          private Button botaoCancelar;
     }
}