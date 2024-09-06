namespace Desafios_04.Programas;

internal class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}
