// ****************Desafio 1****************
// TRATAMENTOS DE ERRO
//using (HttpClient client = new HttpClient())
//{
//    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//    Console.WriteLine(resposta);
//}

// ****************Desafio 2****************

//Console.WriteLine("Digite dois números inteiros, o primeiro será o numerador e o segundo o denominador: ");
//Console.Write("Primeiro numero:");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Segundo numero:");
//int b = int.Parse(Console.ReadLine());
//try
//{
//    int divisao = a / b;
//    Console.WriteLine(divisao);
//}

//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Não pode dividir um número por zero");
//}

// ****************Desafio 3****************

//List<int> listaDeInteiros = new List<int> { 0, 1, 2, 3, 4};
//try
//{
//    Console.WriteLine(listaDeInteiros[5]);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine($"Ocorreu o seguinte erro:\n{e}");
//}

//using Desafios_04;
//try
//{
//    TratamentoDeErroTeste objetoNulo = null;
//    objetoNulo.OlaMundo();
//}
//catch(NullReferenceException e)
//{
//    Console.WriteLine($"Ocorreu o seguinte erro:\n{e}");
//}

// ****************Desafio 4******************
//DESSEREALIZAÇÃO

//using System.Text.Json;
//using Desafios_04.Modelos;
//using (HttpClient client = new HttpClient()) 
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/" +
//        "Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//        Console.WriteLine(json);
//        var filmes = JsonSerializer.Deserialize<List<Filme>>(json);
//        foreach (Filme filme in filmes)
//        {
//            Console.WriteLine(filme.Detalhes);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocorreu o erro: {ex.Message}");
//    }

//}

// ****************Desafio 5******************

//using Desafios_04.Modelos;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/" +
//        "Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
//        //Console.WriteLine(json);
//        var paises = JsonSerializer.Deserialize<List<Pais>>(json);

//        foreach(Pais pais in paises)
//        {
//            Console.WriteLine($"\nDetalhes\n{pais.Detalhes}");
//        }
//    }

//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocorreu o erro: {ex}");
//    }
//}

// ****************Desafio 6******************

//using Desafios_04.Modelos;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/" +
//        "curso-4-aula-2/Jsons/Carros.json");
//        //Console.WriteLine(json);
//        var veiculos = JsonSerializer.Deserialize<List<Carro>>(json);

//        foreach(Carro carro in veiculos)
//        {
//            Console.WriteLine($"Carro:\n{carro.Detalhes}");
//        }
//    }

//    catch(Exception ex)
//    {
//        Console.WriteLine($"Ocorreu o erro: {ex}");
//    }
//}

// ****************Desafio 7******************

//using Desafios_04.Modelos;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/" +
//    "curso-4-aula-2/Jsons/Livros.json");
//        //Console.WriteLine(json);
//        var livros = JsonSerializer.Deserialize<List<Livro>>(json);

//        foreach(Livro livro in livros)
//        {
//            Console.WriteLine($"\nInformações do livro\n{livro.Detalhes}");
//        }

//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine($"Ocorreu o erro: {ex}");
//    }
//}

// ****************Desafio 7 ******************

//using Desafios_04.Modelos;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
//        //Console.WriteLine(json);
//        Personagem personagem = JsonSerializer.Deserialize<Personagem>(json)!;
//        personagem.ExibirApelidosDaPersonagem();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex);
//    }
//}

// ****************Desafio 8******************

//using Desafios_04.Filtros;
//List <int> listaDeNumerosInteiros = new List<int> { 1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9, 9, 10 };
//List <int> listaDeNumerosInteiros2 = new List<int> { 1, 2, 3 };
//LinqFilter.FiltraValoresUnicos(listaDeNumerosInteiros);
//Console.WriteLine();
//LinqFilter.FiltraValoresEmComum(listaDeNumerosInteiros, listaDeNumerosInteiros2);

// ****************Desafio 9******************

//using Desafios_04.Modelos;
//using Desafios_04.Filtros;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/" +
//    "curso-4-aula-2/Jsons/Livros.json");
//        //Console.WriteLine(json);
//        var livros = JsonSerializer.Deserialize<List<Livro>>(json);

//        LinqFilter.FiltraLivrosOrdenados(livros!);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocorreu o erro: {ex}");
//    }
//}

// ****************Desafio 10******************

//using Desafios_04.Modelos;

//List<Produto> listaDeProdutos = new List<Produto>
//{
//    new Produto {Nome = "Televisão", Preco = 4000},
//    new Produto {Nome = "Tablet", Preco = 2500},
//    new Produto {Nome = "PC Gamer", Preco = 7000}
//};
//var mediaDosProdutos = listaDeProdutos.Average(p => p.Preco);
//Console.WriteLine($"A média do preço dos produtos é: {mediaDosProdutos}");

// ****************Desafio 11******************

//List<int> listaDeNumerosInteiros = new List<int> { 1, 2,3, 4, 5, 6, 7, 8, 9, 10 };

//var listaDePares = listaDeNumerosInteiros.Where(numero => numero % 2 == 0);
//foreach(var numero in listaDePares)
//{
//    Console.Write(numero + " ");
//}

// ****************Desafio 12******************

// Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail),
// serializa essas informações em formato JSON e salva em um arquivo.

//using Desafios_04.Programas;
//using System.Text.Json;
//Console.WriteLine("Bem vindo ao programa!\nIremos solicitar algumas informações e gerar um json com seus dados");

//Console.Write("Digite seu nome: ");
//string nome = Console.ReadLine();
//Console.Write("Digite seu email: ");
//string email = Console.ReadLine();
//Console.Write("Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//Pessoa dadosPessoais = new Pessoa(nome, email, idade);

//string jsonString = JsonSerializer.Serialize(dadosPessoais);
//string nomeDoArquivo = $"pessoa.json";

//File.WriteAllText(nomeDoArquivo, jsonString);

//Console.WriteLine($"Os dados foram salvos em {Path.GetFullPath(nomeDoArquivo)}");

// ****************Desafio 13******************

//Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

//using Desafios_04.Programas;
//using System.Text.Json;

//string nomeDoArquivo = $"pessoa.json";
//// Verificando se o arquivo existe
//if (File.Exists(nomeDoArquivo))
//{
//    // Lendo conteúdo do json
//    string jsonString = File.ReadAllText(nomeDoArquivo);

//    // Desserealizando arquivo json
//    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

//    Console.WriteLine($"{pessoa.Nome}\n{pessoa.Email}\n{pessoa.Idade}");
//}
//else
//{
//    Console.WriteLine($"O arquivo: {nomeDoArquivo} não existe");
//}

// ****************Desafio 14******************
//Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

// using Desafios_04.Programas;
// using System.Text.Json;
// List<Pessoa> listaDePessoas = [];

// Console.WriteLine("Adicione dados das pessoas, quando terminar pressione a tecla esc");

// do
// {
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine();
//    Console.Write("Email: ");
//    string email = Console.ReadLine();
//    Console.Write("Idade: ");
//    int idade = int.Parse(Console.ReadLine());

//    Pessoa dadosPessoais = new Pessoa(nome, email, idade);
//    listaDePessoas.Add(dadosPessoais);
//    Console.WriteLine("Pressione a tecla enter para adicionar mais um usuário, ou esc para sair");
// }
// while (Console.ReadKey().Key != ConsoleKey.Escape);

// string jsonString = JsonSerializer.Serialize(listaDePessoas);
// string fileName = "pessoas.json";
// File.WriteAllText(fileName, jsonString);
// Console.WriteLine($"Os dados foram salvos em {fileName}");

// ****************Desafio 15******************
// Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.
//using Desafios_04.Programas;
//using System.Text.Json;

//string fileName = "pessoas.json";

//if (File.Exists(fileName))
//{
//    // Lendo conteúdo do json
//    string jsonString = File.ReadAllText(fileName);

//    // Desserealizando arquivo json
//    var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
//    Console.WriteLine("Informações das pessoas:\n");
//    foreach (Pessoa pessoa in pessoas!)
//    {
//        Console.WriteLine($"{pessoa.Nome}\n{pessoa.Email}\n{pessoa.Idade}\n");
//    }

//}
//else
//{
//    Console.WriteLine($"O arquivo: {fileName} não existe");
//}

// ****************Desafio 16******************
// Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

using Desafios_04.Programas;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    // Lendo conteúdo do json
    string jsonString = File.ReadAllText(fileName);

    // Desserealizando arquivo json
    List<Pessoa>? pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
    Console.Write("Digite a idade que deseja filtrar: ");
    int idadeFiltro = int.Parse(Console.ReadLine());

    List<Pessoa> pessoasFiltradas = pessoas.Where(i => i.Idade == idadeFiltro).ToList();

    if (pessoasFiltradas.Any())
    {
        foreach (Pessoa pessoa in pessoasFiltradas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}\nEmail: {pessoa.Email}\nIdade:{pessoa.Idade}");
        }
    }
    else
    {
        Console.WriteLine($"Não existem indivíduos com {idadeFiltro} anos na base de dados");
    }
}
else
{
    Console.WriteLine($"O arquivo: {fileName} não existe");
}

