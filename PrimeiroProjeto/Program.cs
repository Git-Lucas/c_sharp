using PrimeiroProjeto.EntitiesWork;
using PrimeiroProjeto.EntitiesWork.Enums;
using System;
using System.Collections.Generic;
using PrimeiroProjeto.EntitiesSocialMedia;
using PrimeiroProjeto.EntitiesStore;
using PrimeiroProjeto.EntitiesStore.Enums;
using PrimeiroProjeto.EntitiesEmployees;
using PrimeiroProjeto.EntitiesProducts;
using PrimeiroProjeto.EntitiesPayer;
using PrimeiroProjeto.EntitiesAccount;
using PrimeiroProjeto.EntitiesAccount.Exceptions;
using System.IO;
using PrimeiroProjeto.EntitiesItemProduct;
using System.Globalization;
using PrimeiroProjeto.Contracts.Entities;
using PrimeiroProjeto.Contracts.Services;
using PrimeiroProjeto.EntitiesCourse;
using PrimeiroProjeto.EntitiesElections;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Produto 1 (string):");
            //string produto1 = Console.ReadLine();
            //Console.WriteLine("\nProduto 2 (string):");
            //string produto2 = Console.ReadLine();

            //Console.WriteLine("\nIdade (byte):");
            //byte idade = byte.Parse(Console.ReadLine());
            //Console.WriteLine("\nCodigo (int):");
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

            //int aux;
            ////Um vetor será criado, e deve ser preenchido o tamanho da matriz: 2 dimensões
            //string[] tamanho = Console.ReadLine().Split(' ');
            ////O primeiro e o segundo valor são utilizados para a definição das linhas e colunas, respectivamente
            //int[,] matriz = new int[int.Parse(tamanho[0]), int.Parse(tamanho[1])];

            ////Preenchimento do vetor
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    //Armazenamento no vetor 'valores', de todos os valores da linha 'i', separando por 'espaço'
            //    string[] valores = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        //Preenchimento no vetor dos valores de todas as colunas da linha 'i'
            //        matriz[i, j] = int.Parse(valores[j]);
            //    }
            //}

            //Console.Write("\nNúmero a ser procurado: ");
            //aux = int.Parse(Console.ReadLine());

            ////For para percorrer todas as linhas da 'matriz'
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    //For para percorrer todas as colunas da 'matriz'
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        //Verificação se o valor da 'matriz' na posição, é igual ao número procurado
            //        if (matriz[i, j] == aux)
            //        {
            //            //Informa a posição do valor
            //            Console.WriteLine($"\nPosição: {i},{j}");
            //            //Verificação se não é a primeira posição da esquerda
            //            if (j > 0)
            //            {
            //                Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
            //            }
            //            //Verificação se não é a última posição da direita
            //            if (j < matriz.GetLength(1) - 1)
            //            {
            //                Console.WriteLine($"Direita: {matriz[i, j + 1]}");
            //            }
            //            //Verificação se não é a primeira posição de cima
            //            if (i > 0)
            //            {
            //                Console.WriteLine($"Acima: {matriz[i - 1, j]}");
            //            }
            //            //Verificação se não é a última posição de baixo
            //            if (i < matriz.GetLength(0) - 1)
            //            {
            //                Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
            //            }
            //        }
            //    }
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Declaração das variáveis
            //string nameDepartment;
            //string nameWorker;
            //WorkerLevel level;
            //double baseSalary;
            //int resposta;
            //DateTime date;
            //double valuePerHour;
            //int hours;
            //string period;

            ////Entrada e leitura de dados Department
            //Console.Write("Enter department's name: ");
            //nameDepartment = Console.ReadLine();
            ////Instancia Department
            //Department department = new Department(nameDepartment);

            ////Entrada e leitura de dados Worker
            //Console.Write("\n\nEnter worker data:\nName: ");
            //nameWorker = Console.ReadLine();
            //Console.Write("Level (Junior / MidLevel / Senior): ");
            //level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            //Console.Write("Base salary: ");
            //baseSalary = double.Parse(Console.ReadLine());
            ////Instancia Worker
            //Worker worker = new Worker(nameWorker, level, baseSalary, department);

            ////Entrada e leitura do número de contratos que serão cadastrados
            //Console.Write("\n\nHow many contracts to this worker? ");
            //resposta = int.Parse(Console.ReadLine());
            //for (int i = 0; i < resposta; i++)
            //{
            //    //Entrada e leitura de dados HourContract
            //    Console.Write($"\nEnter #{i + 1} contract data:\nDate (DD/MM/YYYY): ");
            //    date = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    valuePerHour = double.Parse(Console.ReadLine());
            //    Console.Write("Duration (hours): ");
            //    hours = int.Parse(Console.ReadLine());
            //    //Instancia HourContract
            //    HourContract contract = new HourContract(date, valuePerHour, hours);
            //    //Adiciona o objeto HourContract ao objeto Worker
            //    worker.AddContract(contract);
            //}

            ////Entrada e leitura do período a ser consultado
            //Console.Write("\n\nEnter month and year to calculate income (MM/YYYY): ");
            //period = Console.ReadLine();
            ////Exibição dos dados do objeto Worker, e do faturamento no período
            //Console.Write($"Name: {worker.Name}" +
            //    $"\nDepartment: {worker.Department.Name}" +
            //    $"\nIncome for {period}: R$ {worker.Income(int.Parse(period.Substring(3)), int.Parse(period.Substring(0, 2))).ToString("F2")}");

            //----------------------------------------------------------------------------------------------------------------

            //Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zeland", "I'm going to visit this wonderful contry!", 12);
            //Comment comment1 = new Comment("Have a nice trip");
            //Comment comment2 = new Comment("Wow that's awesome!");
            //post1.AddComment(comment1);
            //post1.AddComment(comment2);

            //Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            //Comment comment3 = new Comment("Good night");
            //Comment comment4 = new Comment("Maybe the Force be with you");
            //post2.AddComment(comment1);
            //post2.AddComment(comment2);

            //Console.WriteLine(post1);
            //Console.WriteLine(post2);

            //----------------------------------------------------------------------------------------------------------------

            ////Declarando as variáveis
            //string nameClient;
            //string emailClient;
            //DateTime birthDate;
            //OrderStatus status;
            //int quantityItems;

            ////Entrada e leitura de dados Client
            //Console.Write("Enter client data:" +
            //    "\nName: ");
            //nameClient = Console.ReadLine();
            //Console.Write("Email: ");
            //emailClient = Console.ReadLine();
            //Console.Write("Birth date (DD/MM/YYYY): ");
            //birthDate = DateTime.Parse(Console.ReadLine());
            ////Instancia Client
            //Client client = new Client(nameClient, emailClient, birthDate);

            ////Entrada e leitura dos dados Order
            //Console.Write("\nEnter order data:" +
            //    "\nStatus: ");
            //status = Enum.Parse<OrderStatus>(Console.ReadLine());
            ////Instancia Order, com data atual, status definido pelo usuário, e objeto Client instanciado
            //Order order = new Order(DateTime.Now, status, client);

            ////Entrada e leitura da quantidade de itens que serão comprados
            //Console.Write("How many items to this order? ");
            //quantityItems = int.Parse(Console.ReadLine());
            //for (int i = 0; i < quantityItems; i++)
            //{
            //    //Entrada e leitura dos dados Product
            //    Console.Write($"\nEnter #{i + 1} item data:" +
            //        $"\nProduct name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Product price: ");
            //    double productPrice = double.Parse(Console.ReadLine());
            //    //Instancia Product
            //    Product product = new Product(productName, productPrice);

            //    //Entrada e leitura da quantidade do produto instanciado
            //    Console.Write("Quantity: ");
            //    int quantityProduct = int.Parse(Console.ReadLine());
            //    //Instancia OrderItem com a quantidade e o produto instanciado
            //    OrderItem orderItem = new OrderItem(quantityProduct, product);
            //    //Adiciona o objeto OrderItem à lista na classe Order
            //    order.AddItem(orderItem);
            //}

            ////Imprime ToString Order
            //Console.Write($"\n{order}");

            //----------------------------------------------------------------------------------------------------------------

            ////Declaração de variáveis
            //int numberEmployees;
            //List<Employee> employees = new List<Employee>();

            ////Entrada e leitura da quantidade de objetos Employees que são cadastrados na lista
            //Console.Write("Enter the number of employees: ");
            //numberEmployees = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberEmployees; i++)
            //{
            //    //Leitura e entrada dos dados gerais do objeto Employee
            //    Console.Write($"\nEmployee #{i + 1} data:" +
            //        $"\nOursourced (y/n)? ");
            //    char resposta = char.Parse(Console.ReadLine().ToUpper());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Hours: ");
            //    int hours = int.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine());
            //    //Verifica se o Employee é Outsourced
            //    if (resposta == 'Y')
            //    {
            //        //Leitura e entrada do dado específico do OutsourcedEmployee
            //        Console.Write("Additional charge: ");
            //        double additionalCharge = double.Parse(Console.ReadLine());
            //        //Adiciona na lista do tipo Employee, um objeto do tipo OutsourcedEmployee (Upcasting)
            //        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            //    } else
            //    {
            //        //Adiciona na lista do tipo Employee, um objeto do tipo Employee
            //        employees.Add(new Employee(name, hours, valuePerHour));
            //    }
            //}

            ////Apresentação dos dados da lista
            //Console.WriteLine("\n-----------------------------------------------------------" +
            //    "\n\nPAYMENTS: ");
            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine(e);
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Declaração de variáveis auxiliares e declaração e instanciação da lista de Procucts (o EntitiesProducts antes do Product, se deve ao fato de possui outra classe Product em outra pasta)
            //int numeroProdutos;
            //List<EntitiesProducts.Product> products = new List<EntitiesProducts.Product>();

            //Console.Write("Enter the number of products: ");
            //numeroProdutos = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numeroProdutos; i++)
            //{
            //    //Leitura e entrada dos dados gerais do objeto Product
            //    Console.Write($"\nProduct #{i + 1} data: " +
            //        $"\nCommom, used or imported (c/u/i)? ");
            //    char resposta = char.Parse(Console.ReadLine().ToUpper());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());
            //    if (resposta == 'U')
            //    {
            //        //Leitura e entrada de dados específicos UsedProduct
            //        Console.Write("Manufacture date (DD/MM/YYYY): ");
            //        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
            //        //Adiciona na lista de Products, no tipo UsedProduct
            //        products.Add(new UsedProduct(name, price, manufactureDate));
            //    }
            //    else if (resposta == 'I')
            //    {
            //        //Leitura e entrada de dados específicos ImportedProduct
            //        Console.Write("Customs fee: ");
            //        double customsFee = double.Parse(Console.ReadLine());
            //        //Adiciona na lista de Products, no tipo ImportedProduct
            //        products.Add(new ImportedProduct(name, price, customsFee));
            //    } else
            //    {
            //        //Adiciona na lista de Products, no tipo Product
            //        products.Add(new EntitiesProducts.Product(name, price));
            //    }
            //}

            ////Apresenta os dados da lista Product, chamando a função PriceTag, sobrescrita nas classes UsedProduct e ImportedProduct (polimorfismo: apresentando os dados conforme especificação na classe)
            //Console.WriteLine("\n-----------------------------------------------" +
            //    "\nPRICE TAGS:");
            //foreach(EntitiesProducts.Product p in products)
            //{
            //    Console.WriteLine(p.PriceTag());
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Declaração e instanciação das variáveis
            //int numberPayers;
            //List<Payer> payers = new List<Payer>();
            //double totalTaxes = 0;

            ////Leitura e entrada do número de objetos que herdam de Payer que serão cadastrados
            //Console.Write("Enter the number of tax payers: ");
            //numberPayers = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberPayers; i++)
            //{
            //    //Leitura e entrada dos dados comuns a todas as subclasses de Payer
            //    Console.Write($"\nTax  payer #{i + 1} data:" +
            //        $"\nIndividual or company (i/c)? ");
            //    char resposta = char.Parse(Console.ReadLine().ToUpper());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Anual income: ");
            //    double anualIncome = double.Parse(Console.ReadLine());

            //    //Leitura e entrada dos dados de IndividualPayer, e adição deste objeto à lista de objetos Payer
            //    if (resposta == 'I')
            //    {
            //        Console.Write("Health expenditures: ");
            //        double healthExpenditures = double.Parse(Console.ReadLine());
            //        payers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
            //    }
            //    //Leitura e entrada dos dados de CompanyPayer, e adição deste objeto à lista de objetos Payer
            //    else
            //    {
            //        Console.Write("Number of employees: ");
            //        int numberEmployees = int.Parse(Console.ReadLine());
            //        payers.Add(new CompanyPayer(name, anualIncome, numberEmployees));
            //    }
            //}

            ////Apresentação dos dados
            //Console.WriteLine("\n--------------------------------------------------" +
            //    "\n\nTAXES PAID:");

            ////No mesmo foreach que apresenta o valor de impostos pagos por cada Payer, a variável totalTaxes é incrementada
            //foreach (Payer p in payers)
            //{
            //    Console.WriteLine($"{p.Name}: R${p.CalculatesTaxes():F2}");
            //    totalTaxes += p.CalculatesTaxes();
            //}

            //Console.WriteLine($"\nTOTAL TAXES: R${totalTaxes:F2}");

            //----------------------------------------------------------------------------------------------------------------

            //try
            //{
            //    //Declaração de variáveis
            //    int number;
            //    string holder;
            //    double initialDeposit;
            //    double withdrawLimit;

            //    //Leitura e entrada dos dados para instanciação do objeto Account, mais o valor inicial de depósito
            //    Console.Write("Enter account data" +
            //        "\nNumber: ");
            //    number = int.Parse(Console.ReadLine());
            //    Console.Write("Holder: ");
            //    holder = Console.ReadLine();
            //    Console.Write("Initial balance: ");
            //    initialDeposit = double.Parse(Console.ReadLine());
            //    Console.Write("Withdraw limit: ");
            //    withdrawLimit = double.Parse(Console.ReadLine());

            //    //Instanciação do objeto Account
            //    Account account = new Account(number, holder, withdrawLimit);
            //    //Depósito inicial na conta, através do método Deposit da classe Account
            //    account.Deposit(initialDeposit);

            //    //Leitura e entrada do valor para saque
            //    Console.Write("\nEnter amount for withdraw: ");
            //    //Saque através do método Withdraw
            //    account.Withdraw(double.Parse(Console.ReadLine()));
            //    //Apresentação do valor atualizado de saldo
            //    Console.WriteLine($"New balance: {account.Balance}");
            //} catch(DomainException e)
            //{
            //    //Apresentação da mensagem de erro da ApplicationException (exceções da aplicação; e classe pai da DomainException), instanciada na classe Account, no método Withdraw (por isso "WITHDRAW error:")
            //    Console.WriteLine($"Withdraw error: {e.Message}");
            //} catch(Exception e)
            //{
            //    //Apresentação da mensagem de erro da Exception (exceções de sistema), em qualquer erro possível no bloco de código dentro de "try" (entrada de dados inválida por exemplo)
            //    Console.WriteLine($"Unexpected error: {e.Message}");
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Declaração das variáveis
            //string sourcePath;
            //string targetPath;
            //List<ItemProduct> ips = new List<ItemProduct>();

            ////Leitura e entrada do caminho completo do arquivo de entrada (caminho + nome e extensão do arquivo)
            //Console.Write("File path (complete): ");
            //sourcePath = Console.ReadLine();
            ////A pasta destino do arquivo de saída será armazenada como string, a partir da pasta onde se encontra o arquivo de entrada
            //targetPath = @$"{Path.GetDirectoryName(sourcePath)}\out";

            ////Try Catch a partir do momento que começa a manipulação dos arquivos
            //try
            //{
            //    //Using: abre a instância de StreamReader, e fecha automaticamente
            //    using (StreamReader sr = File.OpenText(sourcePath))
            //    {
            //        //O conteúdo do arquivo será percorrido, linha por linha
            //        while (!sr.EndOfStream)
            //        {
            //            //Os dados: Nome, Preço Unitário e Quantidade; serão armazenados no vetor de string nas posições 0, 1 e 2 (separados por "," no arquivo de entrada)
            //            string[] line = sr.ReadLine().Split(",");
            //            //Instanciação (com os dados recuperados da linha) e adição  do objeto à lista, que será percorrida para a gravação dos dados no arquivo de saída                    
            //            ips.Add(new ItemProduct(line[0], double.Parse(line[1], CultureInfo.InvariantCulture), double.Parse(line[2], CultureInfo.InvariantCulture)));
            //        }
            //    }

            //    //Criação da nova pasta "out", informando o caminho completo que foi atribuído à "targetPath"
            //    Directory.CreateDirectory(targetPath);

            //    //Using: abre a instância de StreamWriter, e fecha automaticamente
            //    //Recebe o File.AppendText, que internamente será uma instância do FileStream (trabalhar com arquivos a partir das instâncias, melhora o processamento)
            //    //O File.AppendText receberá o caminho completo do arquivo de saída, e criará o "summary.csv", já pronto para escrita / edição
            //    using (StreamWriter sw = File.AppendText($@"{targetPath}\summary.csv"))
            //    {
            //        //Foreach que percorre a lista de objetos que foram instanciados a partir do arquivo de entrada (1 objeto ItemProduct por linha)
            //        foreach (ItemProduct ip in ips)
            //        {
            //            //Em cada linha do arquivo de saída, será escrito o Nome,ValorTotal (no formato padrão: 0000.00)
            //            sw.WriteLine($"{ip.Name},{ip.Total().ToString("F2", CultureInfo.InvariantCulture)}");
            //        }
            //    }
            //    //Catch para capturar qualquer erro na manipulação dos arquivos
            //} catch (IOException e)
            //{
            //    Console.Write($"An error ocurred: \n{e.Message}");
            //}

            //----------------------------------------------------------------------------------------------------------------

            ////Instanciação das variáveis
            //int contractNumber;
            //DateTime contractDate;
            //double contractValue;

            ////Leitura e entrada dos dados; e instanciação do objeto Contract
            //Console.Write("Enter contract data" +
            //    "\nNumber: ");
            //contractNumber = int.Parse(Console.ReadLine());
            //Console.Write("Date (DD/MM/YYYY): ");
            //contractDate = DateTime.Parse(Console.ReadLine());
            //Console.Write("Contract value: ");
            //contractValue = double.Parse(Console.ReadLine());
            //Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ////Leitura e entrada do número de parcelas do contrato na função que adiciona as parcelas ao contrato
            //Console.Write("Enter number of installments: ");
            //contract.AddInstallments(int.Parse(Console.ReadLine()));

            ////Instanciação da classe que processa o pagamento (PaymentService), informando como parâmetro o objeto PaypalPaymentService (um dos vários serviços de pagamento possíveis, podendo informar qualquer classe que implementa a interface IPaymentService (UpCasting))
            //PaymentService ps = new PaymentService(new PaypalPaymentService());
            ////Função que processa os valores adicionais das parcelas, informando o objeto Contract como parâmetro
            //ps.ProcessInstallments(contract);

            ////Imprime a relação das parcelas já formatadas
            //Console.Write(contract.ToStringInstallments());

            //----------------------------------------------------------------------------------------------------------------

            ////Instanciação do Instructor Alex
            //Instructor instructor = new Instructor("Alex");

            ////Instanciação de 3 Courses
            //instructor.Courses.Add(new Course("A", instructor));
            //instructor.Courses.Add(new Course("B", instructor));
            //instructor.Courses.Add(new Course("C", instructor));

            ////Instanciação da lista completa de Students que serão cadastrados no decorrer da execução
            //List<Student> students = new List<Student>();

            ////Try para captar qualquer erro na instanciação de cada Student, entre outras operações
            //try
            //{
            //    //O exercício solicitava a exibição da quantidade de alunos de um determinado Instruct (por isso a instanciação do Instruct e os Courses para ele)
            //    //Para cada Course que o Instruct possui, serão perguntados quantos Students serão cadastrados
            //    foreach (Course c in instructor.Courses)
            //    {
            //        Console.Write($"How many students for curse {c.Name}? ");
            //        int aux = int.Parse(Console.ReadLine());
            //        //Dentro do foreach de cada Course (variáveis temporárias do escopo foreach), uma lista codesCourse é instanciada sem valores, para preenchimento com os códigos dos alunos cadastrados no curso
            //        HashSet<int> codesCourse = new HashSet<int>();
            //        //For que será executado aux vezes (número de Students que serão adicionados ao Course
            //        for (int i = 0; i < aux; i++)
            //        {
            //            //Leitura e entrada do CodeStudent
            //            int codeStudent = int.Parse(Console.ReadLine());
            //            //A instanciação do Student servirá para comparação se o estudante já foi instanciado alguma vez em tempo de execução ou não (obj.Equals(obj))
            //            Student student = new Student(codeStudent, codesCourse);
            //            //O boolean objExists começa com false a cada entrada de Code, e poderá ser alterado, caso encontrado na lista de Students instanciados em tempo de execução
            //            bool objExists = false;
            //            //Percorre a lista de todos os Students instanciados em tempo de execução
            //            foreach (Student s in students)
            //            {
            //                //Verifica se o Student instanciado (Student não repetido para o Course), já foi instanciado alguma vez em tempo de execução (o Equals vai comparar o Code dos objetos Student)
            //                if (student.Equals(s))
            //                {
            //                    //O Code deste Student será adicionado à lista de códigos dos Students já cadastrados naquele Course
            //                    codesCourse.Add(s.Code);
            //                    //O objeto Student já instanciado, terá o Course do foreach, adicionado à sua lista de Courses na classe Student
            //                    s.Courses.Add(c);
            //                    //O objeto Instruct terá este Student adicionado à sua lista completa de Students
            //                    instructor.Students.Add(s);
            //                    //O objeto Course do foreach, terá o objeto Student adicionado à sua lista
            //                    c.Students.Add(s);
            //                    //O boolean objExists será true (será verificado abaixo)
            //                    objExists = true;
            //                }
            //            }
            //            //Verifica se o objeto instanciado continua não existindo, mesmo após percorrer toda a lista de Students instanciados em tempo de execução, e faz as mesmas operações, mas com a nova instância de Student
            //            if (!objExists)
            //            {
            //                students.Add(student);
            //                codesCourse.Add(codeStudent);
            //                student.Courses.Add(c);
            //                instructor.Students.Add(student);
            //                //Além disso, o novo objeto Student será adicionado à lista de todos os objetos Students instanciados em tempo de execução
            //                c.Students.Add(student);
            //            }
            //        }
            //    }

            //    Console.WriteLine($"\n-------------------------------------------------------------\n\n{instructor}");
            //} catch (Exception e)
            //{
            //    Console.WriteLine($"An error ocurred: {e.Message}");
            //}

            //----------------------------------------------------------------------------------------------------------------

            try
            {
                //Leitura do caminho completo do arquivo
                Console.Write("Enter file full path: ");
                //Instância do Election, informando o caminho completo do arquivo com os registros de votos como parâmetro
                Election election = new Election(Console.ReadLine());

                //Imprime o To String da classe Election, que mostra o resultado, após leitura do arquivo, ordenação do Dictionary, e formatação do string
                Console.WriteLine($"\n{election}");
            } catch(Exception e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }
        }
    }
}
