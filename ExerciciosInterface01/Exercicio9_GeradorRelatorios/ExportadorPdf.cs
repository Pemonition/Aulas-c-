namespace Exercicio9_GeradorRelatorios;

public class ExportadorPdf : IExportadorRelatorio
{
    public void Exportar(List<Venda> vendas)
    {
        Console.WriteLine("ExportadorPdf: gerando relatorio.pdf");
        foreach (Venda venda in vendas)
        {
            Console.WriteLine($"  [PDF] #{venda.Id} {venda.Produto} - R$ {venda.Valor:F2}");
        }
    }
}
