namespace Exercicio9_GeradorRelatorios;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        // Banco de dados + PDF
        GeradorRelatorio relatorio1 = new GeradorRelatorio(new FonteBancoDados(), new ExportadorPdf());
        relatorio1.GerarRelatorioDeVendas();

        Console.WriteLine();

        // Arquivo texto + CSV
        GeradorRelatorio relatorio2 = new GeradorRelatorio(new FonteArquivoTexto(), new ExportadorCsv());
        relatorio2.GerarRelatorioDeVendas();

        Console.WriteLine();

        // API externa + JSON
        GeradorRelatorio relatorio3 = new GeradorRelatorio(new FonteApiExterna(), new ExportadorJson());
        relatorio3.GerarRelatorioDeVendas();
    }
}
