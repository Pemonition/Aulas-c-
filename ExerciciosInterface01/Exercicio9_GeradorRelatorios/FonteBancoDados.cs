namespace Exercicio9_GeradorRelatorios;

public class FonteBancoDados : IFonteDeDados
{
    public List<Venda> BuscarVendas()
    {
        Console.WriteLine("FonteBancoDados: consultando vendas no banco de dados...");
        return new List<Venda>
        {
            new Venda(1, "Teclado Mecanico", 350.00m),
            new Venda(2, "Monitor 27\"", 1200.00m)
        };
    }
}
