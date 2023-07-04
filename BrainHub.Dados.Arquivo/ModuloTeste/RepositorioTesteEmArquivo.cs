using BrainHub.Dados.Arquivo.Compartilhado;
using BrainHub.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Arquivo.ModuloTeste
{
    internal class RepositorioTesteEmArquivo : RepositorioArquivoBase<Teste>, IRepositorioTeste
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

