namespace Exercicio9_GeradorRelatorios;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        Verificar("FonteBancoDados retorna vendas", new FonteBancoDados().BuscarVendas().Count > 0);
        Verificar("FonteArquivoTexto retorna vendas", new FonteArquivoTexto().BuscarVendas().Count > 0);
        Verificar("FonteApiExterna retorna vendas", new FonteApiExterna().BuscarVendas().Count > 0);

        // Combinacao que nao aparece no Program.cs (fonte de API + exportador CSV),
        // prova que qualquer IFonteDeDados funciona com qualquer IExportadorRelatorio
        // sem precisar alterar o GeradorRelatorio.
        Verificar("GeradorRelatorio aceita qualquer combinacao de fonte/exportador",
            ExecutarSemErro(new GeradorRelatorio(new FonteApiExterna(), new ExportadorCsv())));

        Console.WriteLine();
    }

    private static bool ExecutarSemErro(GeradorRelatorio gerador)
    {
        try
        {
            gerador.GerarRelatorioDeVendas();
            return true;
        }
        catch
        {
            return false;
        }
    }

    private static void Verificar(string nome, bool condicao)
    {
        Console.WriteLine(condicao ? $"[OK] {nome}" : $"[FALHOU] {nome}");
    }
}
