using System.Text.Json.Serialization;
namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    private List<string> Tonalidades = new() { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    [JsonPropertyName("year")]

    public string? AnoString { get; set; }
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    public string Tonalidade
    {
        get
        {
            return Tonalidades[Key];
        }
    }

    public void ExibirDetales()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao / 1000}s");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
