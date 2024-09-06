using System.Text.Json.Serialization;

namespace Desafios_04.Modelos;
internal class Pais
{
    [JsonPropertyName("nome")]
    public  string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public  string?  Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int  Habitantes { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string? Lingua { get; set; }

    public string Detalhes => $"País: {Nome}\nCapital: {Capital}\nNúmero de habitantes: {Habitantes}\n" +
        $"Continente: {Continente}\nLíngua:{Lingua}";
}