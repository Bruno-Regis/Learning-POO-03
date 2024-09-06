using System.Text.Json.Serialization;

namespace Desafios_04.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }
    [JsonPropertyName("imDbRating")]
    public string? Imdb { get; set; }
    public string Detalhes => $"Titulo: {Titulo} | Ano: {Ano} | Elenco: {Elenco} | Nota IMDB: {Imdb}";
}
