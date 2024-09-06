using Desafios_04.Modelos;
namespace Desafios_04.Filtros;

internal class LinqFilter
{
    public static void FiltraValoresUnicos(List<int> listaDeNumeros) // Método estático que filtra valores unicos utilizando Linq e printa na tela
    {
        var listaFiltrada = listaDeNumeros.Distinct();
        foreach(int numero in listaFiltrada)
        {
            Console.Write(numero + " ");
        }     
    }

    public static void FiltraValoresEmComum(List<int> listaDeNumeros1, List<int> listaDeNumeros2) // Método estático que filtra valores presentes em duas listas diferentes utilizando Linq e printa na tela
    {
        var numerosEmComum = listaDeNumeros1.Intersect(listaDeNumeros2);
        foreach (int numero in numerosEmComum)
        {
            Console.Write(numero + " ");
        }
    }

    public static void FiltraLivrosOrdenados(List<Livro> listaDeLivros)
    {
        var listaOrdenadaDeLivros = listaDeLivros
            .Where(livro => livro.Ano > 1900)
            .OrderBy(livro => livro.Titulo)
            .Select(livro => livro.Titulo);

        Console.WriteLine("Imprimindo Lista dos livros publicados após o ano de 1900 em ordem afabética:\n");
        foreach (var livro in listaOrdenadaDeLivros)
        {
            Console.WriteLine(livro);
        }
    }
}
