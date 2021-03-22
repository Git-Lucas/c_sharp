using System;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Produto 1 (string):");
            string produto1 = Console.ReadLine();
            Console.WriteLine("\nProduto 2 (string):");
            string produto2 = Console.ReadLine();

            Console.WriteLine("\nIdade (byte):");
            byte idade = byte.Parse(Console.ReadLine());
            Console.WriteLine("\nCodigo (int):");
            //int codigo = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nGênero (char):");
            //char genero = char.Parse(Console.ReadLine());

            //Console.WriteLine($"\nNa mesma linha, informe:\nPreço do {produto1} (double) | Preço do {produto2} (double) | Medida (double) :");
            //string[] vetor = Console.ReadLine().Split(' ');
            //double preco1 = double.Parse(vetor[0]);
            //double preco2 = double.Parse(vetor[1]);
            //double medida = double.Parse(vetor[2]);

            //Console.WriteLine($"\n\n---------RESULTADO---------\nProdutos:\n{produto1}, cujo preço é R${preco1:F2}\n{produto2}, cujo preço é R${preco2:F2}\n\nRegistro: {idade} anos de idade, código {codigo} e gênero '{genero}'\n\nMedida com 6 casa decimais: {medida:F6}\nArredondando para 3 casas decimais: {medida:F3}");

            //----------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Informe valor para A, B e C na mesma linha, separando os valores com ESPAÇO (float):");
            //string[] vetor = Console.ReadLine().Split(' ');
            //float a = float.Parse(vetor[0]);
            //float b = float.Parse(vetor[1]);
            //float c = float.Parse(vetor[2]);
            //float exA = a * c / 2;
            //float exB = (float)(3.14159 * Math.Pow(c, 2));
            //float exC = (a + b) / 2 * c;
            //float exD = (float)Math.Pow(b, 2);
            //float exE = a * b;

            //Console.WriteLine($"\n\n----------RESULTADO----------" +
            //    $"\nA) a área do triângulo retângulo que tem A por base e C por altura:\n{exA:F3}" +
            //    $"\n\nB) a área do círculo de raio C. (pi = 3.14159):\n{exB:F3}" +
            //    $"\n\nC) a áre_a do trapézio que tem A e B por bases e C por altura:\n{exC:F3}" +
            //    $"\n\nD) a área do quadrado que tem lado B:\n{exD:F3}" +
            //    $"\n\nE) a área do retângulo que tem lados A e B:\n{exE:F3}");

            //----------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("OLÁ! SEJA BEM VINDO AO POSTO! \nDigite:\n1.Álcool\n2.Gasolina\n3.Diesel\n4.Fim\n");
            //int alcool = 0, gasolina = 0, diesel = 0;
            //int resposta = int.Parse(Console.ReadLine());

            //while (resposta != 4)
            //{
            //    if (resposta == 1)
            //        alcool++;
            //    else if (resposta == 2)
            //        gasolina++;
            //    else if (resposta == 3)
            //        diesel++;
            //    resposta = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"\nMUITO OBRIGADO!\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");

            //----------------------------------------------------------------------------------------------------------------

            //Console.Write("Digite um número entre 1 e 100: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            //----------------------------------------------------------------------------------------------------------------

            //Console.Write("Digite um número N: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++)
            //{
            //    Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            //}

            //----------------------------------------------------------------------------------------------------------------

            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //x.A = double.Parse(Console.ReadLine());
            //x.B = double.Parse(Console.ReadLine());
            //x.C = double.Parse(Console.ReadLine());

            //Console.WriteLine("\nEntre com as medidas do triângulo Y: ");
            //y.A = double.Parse(Console.ReadLine());
            //y.B = double.Parse(Console.ReadLine());
            //y.C = double.Parse(Console.ReadLine());

            //Console.WriteLine($"\nÁrea do triângulo X: {x.Area().ToString("F3")}\nÁrea do triângulo Y: {y.Area().ToString("F3")}");

            //----------------------------------------------------------------------------------------------------------------

            //Aluno aluno = new Aluno();

            //Console.Write("Nome do aluno: ");
            //aluno.Nome = Console.ReadLine();

            //Console.WriteLine("\nDigite as três notas do aluno: ");
            //aluno.Nota1 = double.Parse(Console.ReadLine());
            //aluno.Nota2 = double.Parse(Console.ReadLine());
            //aluno.Nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine(aluno);

            //----------------------------------------------------------------------------------------------------------------

            //Console.Write("Qual é a cotação do dólar? ");
            //double cotacaoDolar = double.Parse(Console.ReadLine());
            //Console.Write("Quantos dólares você vai comprar? ");
            //double dolares = double.Parse(Console.ReadLine());

            //Console.Write($"Valor a ser pago em reais = R$ {ConversorDeMoeda.ConverteMoeda(cotacaoDolar, dolares).ToString("F2")}");

            //----------------------------------------------------------------------------------------------------------------

            //string nome;
            //double preco;
            //int quantidade;

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade no estoque: ");
            //quantidade = int.Parse(Console.ReadLine());
            //Produto p = new Produto(nome, preco, quantidade);
            //Console.WriteLine($"Dados do produto: {p}");

            //Console.Write("\nDigite o número de produtos a serem adicionados no estoque: ");
            //p.AdicionaProdutos(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Dados atualizados: {p}");

            //Console.Write("\nDigite o número de produtos a serem removidos no estoque: ");
            //p.RemoveProdutos(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Dados atualizados: {p}");

            //----------------------------------------------------------------------------------------------------------------

            //int conta;
            //string nome;
            //double valor;
            //string resposta;
            //ContaBancaria cb;

            //Console.Write("Entre com o número da conta: ");
            //conta = int.Parse(Console.ReadLine());
            //Console.Write("Entre com o nome do titular da conta: ");
            //nome = Console.ReadLine();

            //Console.Write("Haverá depósito inicial (s/n)? ");
            //resposta = Console.ReadLine();
            //if (resposta == "s" || resposta == "S")
            //{
            //    Console.Write("Entre com o valor de depósito incial: ");
            //    valor = double.Parse(Console.ReadLine());
            //    cb = new ContaBancaria(conta, nome, valor);
            //} else
            //{
            //    cb = new ContaBancaria(conta, nome);
            //}

            //Console.WriteLine($"\nDados da conta:\n{cb}");

            //Console.Write("\nEntre com um valor para depósito: ");
            //valor = double.Parse(Console.ReadLine());
            //cb.Deposita(valor);
            //Console.WriteLine($"Dados da conta atualizados:\n{cb}");

            //Console.Write("\nEntre com um valor para saque: ");
            //valor = double.Parse(Console.ReadLine());
            //cb.Saca(valor);
            //Console.WriteLine($"Dados da conta atualizados:\n{cb}");

            //----------------------------------------------------------------------------------------------------------------

            //Estudante[] estudantes = new Estudante[10];

            //int aux = 0;

            //Console.Write("Quantos alunos alugarão os quartos (10 quartos disponíveis)? ");
            //aux = int.Parse(Console.ReadLine());

            //while (!(aux > 0 && aux <= 10))
            //{
            //    Console.Write("Tente novamente! Quantos alunos alugarão os quartos (10 quartos disponíveis)? ");
            //    aux = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < aux; i++)
            //{
            //    Console.WriteLine($"\nHóspede {i + 1}:");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Quarto: ");
            //    int numQuarto = int.Parse(Console.ReadLine());

            //    estudantes[numQuarto] = new Estudante(nome, email, numQuarto);
            //}

            //Console.WriteLine("\nQuartos preenchidos! ");
            //for (int i = 0; i < estudantes.Length; i++)
            //{
            //    if (estudantes[i] != null)
            //    {
            //        Console.WriteLine(estudantes[i]);
            //    }
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Lista de todos os funcionários cadastrados
            //List < Funcionario > funcionarios = new List<Funcionario>();
            ////Vetor que armazena o objeto Funcionario, resultado da busca pelo ID
            //Funcionario[] resultado = new Funcionario[1];
            ////Variável aux, para receber a resposta do usuário
            //int aux;
            ////Boolean para conferir a repetição do ID
            //bool repete;

            //Console.Write("Quantos funcionários serão registrados? ");
            //aux = int.Parse(Console.ReadLine());

            ////For para cadastrar quantos funcionários o usuário quiser
            //for (int i = 0; i < aux; i++)
            //{
            //    Console.WriteLine($"\nFuncionário ({i + 1}):");
            //    Console.Write("ID: ");
            //    int id = int.Parse(Console.ReadLine());
            //    //Boolean se torna true, para entrar no while e fazer a verificação
            //    repete = true;
            //    while (repete)
            //    {
            //        //Falso porque se não entrar no IF de nenhum dos componentes da lista, não existe aquele código, e sai do while
            //        repete = false;
            //        foreach (Funcionario f in funcionarios)
            //        {
            //            if (f.Id == id)
            //            {
            //                repete = true;
            //                Console.Write("ID já existente! Digite outro: ");
            //                id = int.Parse(Console.ReadLine());
            //                break;
            //            }
            //        }
            //    }
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Salário: ");
            //    double salario = double.Parse(Console.ReadLine());
            //    funcionarios.Add(new Funcionario(id, nome, salario));
            //}

            //Console.Write("\nInforme o ID do funcionário que terá o acréscimo de salário: ");
            //aux = int.Parse(Console.ReadLine());
            //foreach (Funcionario f in funcionarios)
            //{
            //    if (f.Id == aux)
            //    {
            //        //Adiciona o objeto completo ao vetor resultado da busca
            //        resultado[0] = f;
            //    }
            //}
            ////Se o vetor possuir objeto, é solicitada a porcentagem para atualização do salário do funcionário
            //if (resultado[0] != null)
            //{
            //    Console.Write("Porcentagem: ");
            //    double porcentagem = double.Parse(Console.ReadLine());
            //    //Posição 0, porque o vetor possui apenas 1 elemento: resultado da busca
            //    resultado[0].AtualizaSalario(porcentagem);
            //} else
            //{
            //    Console.WriteLine("Esse ID não existe!");
            //}

            //Console.WriteLine("\nLista atualizada de funcionários: ");
            //foreach (Funcionario f in funcionarios)
            //{
            //    Console.WriteLine(f);
            //}

            //----------------------------------------------------------------------------------------------------------------

            //int[,] matriz;
            //int aux;
            //int negativos = 0;

            //Console.Write("Número de linhas e colunas da matriz que será criada: ");
            //aux = int.Parse(Console.ReadLine());
            //matriz = new int[aux, aux];

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = int.Parse(valores[j]);
            //    }
            //}

            //Console.WriteLine("\nDiagonal principal:");
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.Write($"{matriz[i, i]} ");
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (matriz[i, j] < 0)
            //        {
            //            negativos++;
            //        }
            //    }
            //}
            //Console.WriteLine($"\n\nNúmeros negativos = {negativos}");

            //----------------------------------------------------------------------------------------------------------------

            int aux;
            //Um vetor será criado, e deve ser preenchido o tamanho da matriz: 2 dimensões
            string[] tamanho = Console.ReadLine().Split(' ');
            //O primeiro e o segundo valor são utilizados para a definição das linhas e colunas, respectivamente
            int[,] matriz = new int[int.Parse(tamanho[0]), int.Parse(tamanho[1])];

            //Preenchimento do vetor
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //Armazenamento no vetor 'valores', de todos os valores da linha 'i', separando por 'espaço'
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Preenchimento no vetor dos valores de todas as colunas da linha 'i'
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("\nNúmero a ser procurado: ");
            aux = int.Parse(Console.ReadLine());

            //For para percorrer todas as linhas da 'matriz'
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //For para percorrer todas as colunas da 'matriz'
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Verificação se o valor da 'matriz' na posição, é igual ao número procurado
                    if (matriz[i, j] == aux)
                    {
                        //Informa a posição do valor
                        Console.WriteLine($"\nPosição: {i},{j}");
                        //Verificação se não é a primeira posição da esquerda
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        }
                        //Verificação se não é a última posição da direita
                        if (j < matriz.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        }
                        //Verificação se não é a primeira posição de cima
                        if (i > 0)
                        {
                            Console.WriteLine($"Acima: {matriz[i - 1, j]}");
                        }
                        //Verificação se não é a última posição de baixo
                        if (i < matriz.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
