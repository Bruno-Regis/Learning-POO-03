using System.Text.Json;

namespace ScreenSoundAPI.Modelos;
class MusicasFavoritas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        foreach(Musica musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"{musica.Nome} de {musica.Artista}");
            Console.WriteLine();
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new             //Serializando json
        {
            nome = Nome, 
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);               //Método estático da File que escreve o arquivo json
        Console.WriteLine($"O arquivo Json foi criado com sucesso!\nlocal:{Path.GetFullPath(nomeDoArquivo)}");
    }
}
