using System.Text.Json;

namespace Exercicio9_GeradorRelatorios;

public class ExportadorJson : IExportadorRelatorio
{
    public void Exportar(List<Venda> vendas)
    {
        Console.WriteLine("ExportadorJson: gerando relatorio.json");
        string json = JsonSerializer.Serialize(vendas, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
    }
}
