using ScreenSoundAPI.Modelos;
namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(musica => musica.Genero).Distinct().ToList();// Para cada musica dentro da lista de musicas
                                                                                               // retorna musica.genero (genero), depois uso 
                                                                                               //Distinct para trazer uniques e transformo em list
        foreach(var genero in todosGenerosMusicais)
        {
            Console.WriteLine($"Genero musical - {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistaPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)) // Parece SQL o where, para cada musica dentro da lista de objetos 
            .Select(musica => musica.Artista)                                           // retorno musica.genero (genero) que contenha o parâmetro genero através do método contains de strings
            .Distinct().ToList();                                                       // pois podem haver subdivisoes de genero por exemplo rock classico, rock alternativo


        Console.WriteLine($"Filtro pelo genero {genero}\n");
        foreach (var artista in artistaPorGenero)
        {           
            Console.WriteLine($"Artistas {artista}");
        }
    }
    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicaPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)) // Assim como no método acima, só que retorno musica.artista que seja exatamente
            .Select(musica => musica.Nome)                                              // igual ao parâmetro artista através do método Equals de strings
            .ToList();

        Console.WriteLine($"Musicas do artista ou banda {artista}");
        foreach(var musica in musicaPorArtista)
        {
            Console.WriteLine($"Musica: {musica}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicaPorAno = musicas.Where(musica => musica.Ano! == ano) // Agora utilizando where, paara cada musica dentro da lista,
            .OrderBy(musica => musica.Nome)                            //  retornar musica.ano == ao parâmetro ano pois estamos trabalhando com inteiro
            .Select(musica=> musica.Nome)
            .Distinct().ToList();
        Console.WriteLine($"Musicas no ano de {ano}");
        foreach (var musica in musicaPorAno)
        {
            Console.WriteLine($"Musica: {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas
        .Where(musica => musica.Tonalidade
        .Equals(tonalidade))
        .Select(musica=>musica.Nome).ToList();
        Console.WriteLine($"Musicas em {tonalidade}");
        foreach(var musica in musicasPorTonalidade)
        {
            Console.WriteLine(musica);
        }
    }
}
