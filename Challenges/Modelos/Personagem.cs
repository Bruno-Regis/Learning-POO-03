using System.Text.Json.Serialization;

namespace Desafios_04.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("aliases")]
    public List<string>? Apelidos { get; set; }

    public void ExibirApelidosDaPersonagem()
    {
        if(Apelidos!= null)
        {
            Console.WriteLine($"Nome: {Nome}");     
            Console.WriteLine("Apelidos:");
            foreach (string apelido in Apelidos)
            {            
                Console.WriteLine($"- {apelido}");
            }
        }
        else Console.WriteLine("Lista de apelidos vazia");
    }
}
