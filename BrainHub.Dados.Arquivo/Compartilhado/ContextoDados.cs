using System.Text.Json;
using System.Text.Json.Serialization;

using BrainHub.Dominio.ModuloDisciplina;
using BrainHub.Dominio.ModuloMateria;

namespace BrainHub.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string CAMINHO_ARQUIVO = "Compartilhado\\BrainHub.json";

        public List<Disciplina> disciplinas;
        public List<Materia> materias;
        public List<Teste> testes;
        public ContextoDados()
        {
            disciplinas = new List<Disciplina>();
            materias = new List<Materia>();
            testes = new List<Teste>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarArquivoJson();
        }

        public void GravarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            string registrosJson = JsonSerializer.Serialize(this, configuracoes);

            File.WriteAllText(CAMINHO_ARQUIVO, registrosJson);
        }

        private void CarregarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            if (File.Exists(CAMINHO_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(CAMINHO_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados dadosJson = JsonSerializer.Deserialize<ContextoDados>(registrosJson, configuracoes);

                    disciplinas = dadosJson.disciplinas;
                    materias = dadosJson.materias;
                    testes = dadosJson.testes;
                }
            }
        }

        private static JsonSerializerOptions ConfigurarSerializadorJson()
        {
            JsonSerializerOptions configuracoes = new JsonSerializerOptions();
            configuracoes.IncludeFields = true;
            configuracoes.WriteIndented = true;
            configuracoes.ReferenceHandler = ReferenceHandler.Preserve;

            return configuracoes;
        }
    }
}
