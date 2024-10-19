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
        Universidade princeton = new Universidade("Princeton (New Jersey, EUA)");
        Universidade cambridge = new Universidade("Cambridge (England, UK)");

        Pessoa einstein = new Pessoa("Albert Einstein", "14/03/1879");
        Pessoa newton = new Pessoa("Isaac Newton", "04/01/1643");

        einstein.SetUniversidade(princeton);
        newton.SetUniversidade(cambridge);

        Console.WriteLine("Informações sobre os cientistas e suas universidades:");
        Console.WriteLine("------------------------------------------------------");
        
        einstein.MostrarInformacoes();
        newton.MostrarInformacoes();
    }
}