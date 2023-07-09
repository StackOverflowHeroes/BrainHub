using BrainHub.Dados.Banco.ModuloDisciplina;
using BrainHub.Dados.Banco.ModuloMateria;
using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;
using BrainHub.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHub.Dados.Banco.ModuloTeste
{
    internal class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);
            comando.Parameters.AddWithValue("NOME", registro.nome);
            comando.Parameters.AddWithValue("NUMERO_QUESTOES", registro.numeroQuestoes);
            comando.Parameters.AddWithValue("PROVA_RECUPERACAO", SqlDbType.Bit).Value = registro.provaRecuperacao;
            comando.Parameters.AddWithValue("SERIE", registro.serie);
            comando.Parameters.AddWithValue("DATA", registro.data);          
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
            DateTime data = Convert.ToDateTime(leitorRegistros["DATA"]);
            bool provaRecuperacao = Convert.ToBoolean(leitorRegistros["PROVA_RECUPERACAO"]);
            

            teste.id = id;
            teste.nome = nome;
            teste.numeroQuestoes = numeroQuestoes;
            teste.disciplina = disciplina;
            teste.materia = materia;
            teste.data = data;
            teste.provaRecuperacao = provaRecuperacao;
            
            return new Teste();
        }
    }
}
