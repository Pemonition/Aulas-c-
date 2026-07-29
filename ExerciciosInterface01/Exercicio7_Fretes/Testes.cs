namespace Exercicio7_Fretes;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        ProdutoLivro livro = new ProdutoLivro("Livro Teste", 50m);
        ProdutoEletronico eletronico = new ProdutoEletronico("Eletronico Teste", 500m);
        ProdutoMovel movel = new ProdutoMovel("Movel Teste", 800m);

        Verificar("Livro: frete fixo de R$ 5,00 com 0 Km", livro.CalcularFrete(0) == 5.00m);
        Verificar("Livro: frete fixo de R$ 5,00 com 100 Km", livro.CalcularFrete(100) == 5.00m);
        Verificar("Eletronico: R$ 1,00 por Km (50 Km = R$ 50,00)", eletronico.CalcularFrete(50) == 50.00m);
        Verificar("Movel: R$ 2,50 por Km + R$ 20,00 fixo (50 Km = R$ 145,00)", movel.CalcularFrete(50) == 145.00m);

        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarItem(livro);
        carrinho.AdicionarItem(eletronico);
        carrinho.AdicionarItem(movel);
        Verificar("CarrinhoDeCompras: frete total para 50 Km = R$ 200,00", carrinho.CalcularFreteTotal(50) == 200.00m);

        Console.WriteLine();
    }

    private static void Verificar(string nome, bool condicao)
    {
        Console.WriteLine(condicao ? $"[OK] {nome}" : $"[FALHOU] {nome}");
    }
}
