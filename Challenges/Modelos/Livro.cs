using System.Text.Json.Serialization;

namespace Desafios_04.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int Ano { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    [JsonPropertyName("paginas")]
    public int NumeroDePaginas { get; set; }

    [JsonPropertyName("editora")]
    public string? Editora { get; set; }

    public string Detalhes => $"Titulo: {Titulo}\nAutor: {Autor}\nAno da publicação: {Ano}\nGenero: {Genero}\n" +
        $"Número de páginas: {NumeroDePaginas}\nEditora: {Editora}";
}