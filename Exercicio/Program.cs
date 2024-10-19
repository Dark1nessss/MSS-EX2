using System;

public class Invoice{

    private string numeroItem;
    private string descricao;
    private int quantidade;
    private double precoUnidade;

    public Invoice(string numeroItem, string descricao, int quantidade, double precoUnidade){
        this.numeroItem = numeroItem;
        this.descricao = descricao;
        this.quantidade = quantidade > 0 ? quantidade : 0;
        this.precoUnidade = precoUnidade > 0 ? precoUnidade : 0.0;
    }

    public string GetNumeroItem(){
        return numeroItem;
    }

    public void SetNumeroItem(string numeroItem)
    {
        this.numeroItem = numeroItem;
    }


    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string descricao)
    {
        this.descricao = descricao;
    }


    public int GetQuantidade()
    {
        return quantidade;
    }

    public void SetQuantidade(int quantidade)
    {
        this.quantidade = quantidade > 0 ? quantidade : 0;
    }


    public double GetPrecoUnitario()
    {
        return precoUnidade;
    }

    public void SetPrecoUnitario(double precoUnidade)
    {
        this.precoUnidade = precoUnidade > 0 ? precoUnidade : 0.0;
    }

    public double GetInvoiceAmount()
    {
        return quantidade * precoUnidade;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice1 = new Invoice("001", "Teclado Mecânico", 5, 250.0);

        Console.WriteLine("Número do Item: " + invoice1.GetNumeroItem());
        Console.WriteLine("Descrição: " + invoice1.GetDescricao());
        Console.WriteLine("Quantidade: " + invoice1.GetQuantidade());
        Console.WriteLine("Preço Unitário: € " + invoice1.GetPrecoUnitario());
        Console.WriteLine("Valor da Fatura: € " + invoice1.GetInvoiceAmount());

        invoice1.SetQuantidade(3);
        invoice1.SetPrecoUnitario(200.0);

        Console.WriteLine("\n--- Após Atualizações ---");
        Console.WriteLine("Quantidade Atualizada: " + invoice1.GetQuantidade());
        Console.WriteLine("Preço Unitário Atualizado: € " + invoice1.GetPrecoUnitario());
        Console.WriteLine("Novo Valor da Fatura: € " + invoice1.GetInvoiceAmount());


        invoice1.SetQuantidade(-10);
        invoice1.SetPrecoUnitario(-50.0);

        Console.WriteLine("\n--- Após Tentativa de Valores Inválidos ---");
        Console.WriteLine("Quantidade: " + invoice1.GetQuantidade()); // 0
        Console.WriteLine("Preço Unitário:  € " + invoice1.GetPrecoUnitario()); // 0.0
        Console.WriteLine("Valor da Fatura: € " + invoice1.GetInvoiceAmount()); // 0.0
    }
}