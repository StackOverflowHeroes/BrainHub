﻿using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainHub.WinApp.ModuloTeste
{
    public partial class TelaDetalhesTesteForm : Form
    {

        public TelaDetalhesTesteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void ConfigurarTela(Teste testeSelecionado)
        {
            string materiaNome = "";

            if (testeSelecionado.materia != null)
                materiaNome = testeSelecionado.materia.nome;

            TextBoxTitulo.Text = testeSelecionado.nome;
            TextBoxDisciplina.Text = testeSelecionado.disciplina.nome;
            TextBoxMatéria.Text = materiaNome;

            foreach (Questao q in testeSelecionado.listaQuestoes)
            {
                listBoxQuestoes.Items.Add(q);
            }
        }

    }
}
