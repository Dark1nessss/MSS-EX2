using System;

public class Universidade
{
    private string nome;

    public Universidade(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }
}

public class Pessoa
{
    private string nome;
    private string dataNascimento;
    private Universidade universidade;

    public Pessoa(string nome, string dataNascimento)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
    }

    public void SetUniversidade(Universidade universidade)
    {
        this.universidade = universidade;
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetDataNascimento()
    {
        return dataNascimento;
    }

    public string GetUniversidade()
    {
        return universidade != null ? universidade.GetNome() : "Nenhuma universidade associada";
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento}");
        Console.WriteLine($"Universidade: {GetUniversidade()}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome da primeira pessoa: ");
        string nome1 = Console.ReadLine();
        Console.Write("Digite a data de nascimento da primeira pessoa (dd/mm/aaaa): ");
        string dataNascimento1 = Console.ReadLine();

        Console.Write("Digite o nome da universidade associada à primeira pessoa: ");
        string universidade1 = Console.ReadLine();

        Console.Write("Digite o nome da segunda pessoa: ");
        string nome2 = Console.ReadLine();
        Console.Write("Digite a data de nascimento da segunda pessoa (dd/mm/aaaa): ");
        string dataNascimento2 = Console.ReadLine();

        Console.Write("Digite o nome da universidade associada à segunda pessoa: ");
        string universidade2 = Console.ReadLine();

        Universidade uni1 = new Universidade(universidade1);
        Universidade uni2 = new Universidade(universidade2);

        Pessoa pessoa1 = new Pessoa(nome1, dataNascimento1);
        Pessoa pessoa2 = new Pessoa(nome2, dataNascimento2);

        pessoa1.SetUniversidade(uni1);
        pessoa2.SetUniversidade(uni2);

        Console.WriteLine("\nInformações sobre as pessoas e suas universidades:");
        Console.WriteLine("------------------------------------------------------");

        pessoa1.MostrarInformacoes();
        pessoa2.MostrarInformacoes();
    }
}