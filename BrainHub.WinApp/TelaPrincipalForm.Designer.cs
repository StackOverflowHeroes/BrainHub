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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            matériaToolStripMenuItem = new ToolStripMenuItem();
            disciplinaToolStripMenuItem = new ToolStripMenuItem();
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
            btnGerarGabarito = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tslTipoCadastros = new ToolStripLabel();
            panelRegistros = new Panel();
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
            menuStrip1.Size = new Size(955, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { matériaToolStripMenuItem, disciplinaToolStripMenuItem, questõesToolStripMenuItem, testesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // matériaToolStripMenuItem
            // 
            matériaToolStripMenuItem.Name = "matériaToolStripMenuItem";
            matériaToolStripMenuItem.ShortcutKeys = Keys.F1;
            matériaToolStripMenuItem.ShowShortcutKeys = false;
            matériaToolStripMenuItem.Size = new Size(157, 26);
            matériaToolStripMenuItem.Text = "Matéria";
            // 
            // disciplinaToolStripMenuItem
            // 
            disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            disciplinaToolStripMenuItem.Size = new Size(157, 26);
            disciplinaToolStripMenuItem.Text = "Disciplina";
            disciplinaToolStripMenuItem.Click += Disciplina_Click;
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(157, 26);
            questõesToolStripMenuItem.Text = "Questões";
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(157, 26);
            testesToolStripMenuItem.Text = "Testes";
            // 
            // StatusStripRodape
            // 
            StatusStripRodape.ImageScalingSize = new Size(20, 20);
            StatusStripRodape.Items.AddRange(new ToolStripItem[] { TextoRodape });
            StatusStripRodape.Location = new Point(0, 544);
            StatusStripRodape.Name = "StatusStripRodape";
            StatusStripRodape.Size = new Size(955, 26);
            StatusStripRodape.TabIndex = 2;
            StatusStripRodape.Text = "statusStrip1";
            // 
            // TextoRodape
            // 
            TextoRodape.Name = "TextoRodape";
            TextoRodape.Size = new Size(49, 20);
            TextoRodape.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1, btnDuplicarTeste, btnGerarGabarito, toolStripSeparator2, tslTipoCadastros });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(955, 45);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources.addIcon;
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
            btnEditar.Image = Properties.Resources.editIcon;
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
            btnDeletar.Image = Properties.Resources.deleteIcon;
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
            // 
            // btnGerarGabarito
            // 
            btnGerarGabarito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarGabarito.Enabled = false;
            btnGerarGabarito.Image = Properties.Resources.gerar_gabarito;
            btnGerarGabarito.ImageTransparentColor = Color.Magenta;
            btnGerarGabarito.Name = "btnGerarGabarito";
            btnGerarGabarito.Size = new Size(29, 42);
            btnGerarGabarito.Text = "Gerar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // tslTipoCadastros
            // 
            tslTipoCadastros.Name = "tslTipoCadastros";
            tslTipoCadastros.Size = new Size(114, 42);
            tslTipoCadastros.Text = "Tipos Cadastros";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 73);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(955, 471);
            panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 570);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(StatusStripRodape);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripButton btnGerarGabarito;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel tslTipoCadastros;
        private Panel panelRegistros;
    }
}