using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrimeiroProjeto.EntitiesElections
{
    class Election
    {
        //Instanciação do Dictionary que irá armazenas como chave string o nome do candidato; e armazenará como valor int o número de votos recebidos (não há ordenação nenhuma)
        public Dictionary<string, int> Elections { get; protected set; } = new Dictionary<string, int>();

        //No construtor, o parâmetro é o caminho do arquivo que contém os registros de voto
        public Election(string path)
        {
            //O método para leitura do arquivo é chamado
            ReadingFile(path);
        }

        //Método que lê o arquivo de votos e armazena no Dictionary da classe
        public void ReadingFile(string path)
        {
            //Using Stream Reader para abertura da instância no momento da instanciação, e fechamento automático
            //File. para instanciar internamente uma instância do tipo FileStream, gerenciada pelo File
            //o StreamReader vai ler todo o arquivo
            using (StreamReader sr = File.OpenText(path))
            {
                //Enquanto não for o final do arquivo, será lido linha a linha
                while (!sr.EndOfStream)
                {
                    //Cada linha contém o nome e o número de votos do candidato, e essas 2 informações da linha serão gravadas no vetor
                    string[] data = sr.ReadLine().Split(",");
                    //Verifica se já contém o candidato no Dictionary (a chave do Dictionary é o nome, que está na posição 0 do vetor declarado acima)
                    //Por um processamento melhor, é mais lógico verificar primeiro se já possui, pois 1 candidato entrará apenas 1 vez no else (isso significa que na mairoria das vezes, o sistema verificará o mais provável, pulando o else)
                    if (Elections.ContainsKey(data[0]))
                    {
                        //Se o Dictionary já possui aquele candidato, o Value com a quantidade de votos será incrementado
                        Elections[data[0]] += int.Parse(data[1]);
                    } else
                    {
                        //Se o Dictionary não possui aquele candidato, este será criado, e o seu valor declarado (1ª vez)
                        Elections[data[0]] = int.Parse(data[1]);
                    }
                }
            }
        }

        //Sobrescrita do método ToString que irá apresentar o resultado das eleições
        public override string ToString()
        {
            //Declaração de uma var (IOrderedEnumerable<KeyValuePair<string, int>>), que ordenará o Dictionary por Value em ordem descendente (do mais votado, para o menos votado)
            //var sortedElements = from kvp in Elections
            //                     orderby kvp.Value descending
            //                     select kvp;

            var sortedElements = Elections.OrderByDescending(kvp => kvp.Value);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RESULT:");

            //Será impresso o Dictionary ordenado a partir do Dictionary da classe
            foreach (KeyValuePair<string, int> item in sortedElements)
            {
                sb.AppendLine($"{item.Key}: {item.Value}");
            }

            return sb.ToString();
        }
    }
}
