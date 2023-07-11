namespace BrainHub.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinaToolStripMenuItem = new ToolStripMenuItem();
            matériaToolStripMenuItem = new ToolStripMenuItem();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            StatusStripRodape = new StatusStrip();
            TextoRodape = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDuplicarTeste = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            btnPDF = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tslTipoCadastros = new ToolStripLabel();
            panelRegistros = new Panel();
            temporizador = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            StatusStripRodape.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(836, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaToolStripMenuItem, matériaToolStripMenuItem, questõesToolStripMenuItem, testesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaToolStripMenuItem
            // 
            disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            disciplinaToolStripMenuItem.Size = new Size(125, 22);
            disciplinaToolStripMenuItem.Text = "Disciplina";
            disciplinaToolStripMenuItem.Click += Disciplina_Click;
            // 
            // matériaToolStripMenuItem
            // 
            matériaToolStripMenuItem.Name = "matériaToolStripMenuItem";
            matériaToolStripMenuItem.ShortcutKeys = Keys.F1;
            matériaToolStripMenuItem.ShowShortcutKeys = false;
            matériaToolStripMenuItem.Size = new Size(125, 22);
            matériaToolStripMenuItem.Text = "Matéria";
            matériaToolStripMenuItem.Click += Materia_Click;
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(125, 22);
            questõesToolStripMenuItem.Text = "Questões";
            questõesToolStripMenuItem.Click += Questao_Click;
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(125, 22);
            testesToolStripMenuItem.Text = "Testes";
            testesToolStripMenuItem.Click += Teste_Click;
            // 
            // StatusStripRodape
            // 
            StatusStripRodape.ImageScalingSize = new Size(20, 20);
            StatusStripRodape.Items.AddRange(new ToolStripItem[] { TextoRodape });
            StatusStripRodape.Location = new Point(0, 406);
            StatusStripRodape.Name = "StatusStripRodape";
            StatusStripRodape.Padding = new Padding(1, 0, 12, 0);
            StatusStripRodape.Size = new Size(836, 22);
            StatusStripRodape.TabIndex = 2;
            StatusStripRodape.Text = "statusStrip1";
            // 
            // TextoRodape
            // 
            TextoRodape.Name = "TextoRodape";
            TextoRodape.Size = new Size(39, 17);
            TextoRodape.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1, btnDuplicarTeste, btnVisualizar, btnPDF, toolStripSeparator2, tslTipoCadastros });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(836, 45);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources.adicionar;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "toolStripButton1";
            btnInserir.ToolTipText = "Inserir";
            btnInserir.Click += Inserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton1";
            btnEditar.ToolTipText = "Editar";
            btnEditar.Click += Editar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletar.Enabled = false;
            btnDeletar.Image = Properties.Resources.deletar;
            btnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            btnDeletar.ImageTransparentColor = Color.Magenta;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Padding = new Padding(7);
            btnDeletar.Size = new Size(42, 42);
            btnDeletar.Text = "toolStripButton1";
            btnDeletar.ToolTipText = "Deletar";
            btnDeletar.Click += Deletar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnDuplicarTeste
            // 
            btnDuplicarTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicarTeste.Enabled = false;
            btnDuplicarTeste.Image = Properties.Resources.duplicar_teste;
            btnDuplicarTeste.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicarTeste.ImageTransparentColor = Color.Magenta;
            btnDuplicarTeste.Name = "btnDuplicarTeste";
            btnDuplicarTeste.Padding = new Padding(7);
            btnDuplicarTeste.Size = new Size(42, 42);
            btnDuplicarTeste.Text = "toolStripButton1";
            btnDuplicarTeste.ToolTipText = "Duplicar";
            btnDuplicarTeste.Click += DuplicarTeste_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = Properties.Resources.visualizar_teste;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(7);
            btnVisualizar.Size = new Size(42, 42);
            btnVisualizar.Text = "toolStripButton1";
            btnVisualizar.ToolTipText = "Visualizar";
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnPDF
            // 
            btnPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPDF.Enabled = false;
            btnPDF.Image = Properties.Resources.pdf_icon;
            btnPDF.ImageTransparentColor = Color.Magenta;
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(24, 42);
            btnPDF.Text = "toolStripButton1";
            btnPDF.ToolTipText = "Gerar PDF";
            btnPDF.Click += btnPDF_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // tslTipoCadastros
            // 
            tslTipoCadastros.Name = "tslTipoCadastros";
            tslTipoCadastros.Size = new Size(90, 42);
            tslTipoCadastros.Text = "Tipos Cadastros";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Margin = new Padding(3, 2, 3, 2);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(836, 337);
            panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 428);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(StatusStripRodape);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrainHub";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            StatusStripRodape.ResumeLayout(false);
            StatusStripRodape.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem matériaToolStripMenuItem;
        private ToolStripMenuItem disciplinaToolStripMenuItem;
        private ToolStripMenuItem questõesToolStripMenuItem;
        private ToolStripMenuItem testesToolStripMenuItem;
        private StatusStrip StatusStripRodape;
        private ToolStripStatusLabel TextoRodape;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDuplicarTeste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel tslTipoCadastros;
        private Panel panelRegistros;
        private System.Windows.Forms.Timer temporizador;
        private ToolStripButton btnVisualizar;
        private ToolStripButton btnPDF;
    }
}