namespace Exercicio7_Fretes;

public static class Program
{
    public static void Main()
    {
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarItem(new ProdutoLivro("Clean Code", 89.90m));
        carrinho.AdicionarItem(new ProdutoEletronico("Notebook", 3500.00m));
        carrinho.AdicionarItem(new ProdutoMovel("Cadeira Gamer", 1200.00m));

        decimal distanciaKm = 50;
        decimal freteTotal = carrinho.CalcularFreteTotal(distanciaKm);

        Console.WriteLine($"Frete total para uma entrega de {distanciaKm} Km: R$ {freteTotal:F2}");
    }
}
