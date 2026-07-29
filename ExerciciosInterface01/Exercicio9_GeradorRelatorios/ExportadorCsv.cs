namespace Exercicio9_GeradorRelatorios;

public class ExportadorCsv : IExportadorRelatorio
{
    public void Exportar(List<Venda> vendas)
    {
        Console.WriteLine("ExportadorCsv: gerando relatorio.csv");
        Console.WriteLine("  Id,Produto,Valor");
        foreach (Venda venda in vendas)
        {
            Console.WriteLine($"  {venda.Id},{venda.Produto},{venda.Valor:F2}");
        }
    }
}
