using ScreenSoundAPI.Modelos;
namespace ScreenSoundAPI.Filtros;

internal class LinqOrder
{
    public static void OrdenarListaDeArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"Nome do artista/banda - {artista}");
        }
    }
}
