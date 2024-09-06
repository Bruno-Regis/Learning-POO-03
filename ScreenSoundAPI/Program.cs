using System.Runtime.CompilerServices;
using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Desserealização:
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Console.WriteLine(resposta);
        musicas[1].ExibirDetales();
        //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
        //Console.WriteLine();
        //LinqOrder.OrdenarListaDeArtistas(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);

        //MusicasFavoritas listaDoBruno = new("Bruno");

        //listaDoBruno.AdicionarMusica(musicas[107]);
        //listaDoBruno.AdicionarMusica(musicas[217]);
        //listaDoBruno.AdicionarMusica(musicas[97]);
        //listaDoBruno.AdicionarMusica(musicas[17]);
        //listaDoBruno.AdicionarMusica(musicas[67]);

        //listaDoBruno.ExibirMusicasFavoritas();

        //listaDoBruno.GerarArquivoJson();
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex}");
    }
}
 