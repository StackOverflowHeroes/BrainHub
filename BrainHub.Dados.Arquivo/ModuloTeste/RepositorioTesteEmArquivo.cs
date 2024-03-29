﻿using BrainHub.Dados.Arquivo.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Arquivo.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioArquivoBase<Teste>
    {
        public RepositorioTesteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

      

        protected override List<Teste> ObterRegistros()
        {
            return contextoDados.testes;
        }
    }
}

