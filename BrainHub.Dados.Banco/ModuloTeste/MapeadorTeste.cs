﻿using BrainHub.Dados.Banco.ModuloDisciplina;
using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloQuestao;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);
            comando.Parameters.AddWithValue("NOME", registro.nome);
            comando.Parameters.AddWithValue("NUMERO_QUESTOES", registro.numeroQuestoes);
            comando.Parameters.AddWithValue("PROVARECUPERACAO", SqlDbType.Bit).Value = registro.provaRecuperacao ? 1 : 0;
            comando.Parameters.AddWithValue("SERIE", registro.serie);
            comando.Parameters.AddWithValue("TESTE_DATA", registro.data);          
            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.disciplina.id);
            comando.Parameters.AddWithValue("MATERIA_ID", registro.materia == null ? DBNull.Value : registro.materia.id);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            Teste teste = new Teste();
            int id = (int)leitorRegistros["TESTE_ID"];
            string nome = Convert.ToString(leitorRegistros["TESTE_NOME"]);
            int numeroQuestoes = Convert.ToInt32(leitorRegistros["NUMERO_QUESTOES"]);
            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);
            Materia materia = null;
            if (leitorRegistros["MATERIA_ID"] != DBNull.Value)
                materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);
            bool provaRecuperacao = Convert.ToBoolean(leitorRegistros["PROVA_RECUPERACAO"]);
            DateTime data = Convert.ToDateTime(leitorRegistros["TESTE_DATA"]);
            

            teste.id = id;
            teste.nome = nome;
            teste.numeroQuestoes = numeroQuestoes;
            teste.disciplina = disciplina;
            teste.materia = materia;
            teste.provaRecuperacao = provaRecuperacao;
            teste.data = data;

            return teste;
        }
    }
}
