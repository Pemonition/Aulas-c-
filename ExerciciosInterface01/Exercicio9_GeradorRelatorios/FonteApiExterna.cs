namespace Exercicio9_GeradorRelatorios;

public class FonteApiExterna : IFonteDeDados
{
    public List<Venda> BuscarVendas()
    {
        Console.WriteLine("FonteApiExterna: buscando vendas em uma API externa...");
        return new List<Venda>
        {
            new Venda(4, "Cadeira Ergonomica", 980.00m)
        };
    }
}
