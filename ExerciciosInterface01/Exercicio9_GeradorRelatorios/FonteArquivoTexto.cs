namespace Exercicio9_GeradorRelatorios;

public class FonteArquivoTexto : IFonteDeDados
{
    public List<Venda> BuscarVendas()
    {
        Console.WriteLine("FonteArquivoTexto: lendo vendas de um arquivo .txt...");
        return new List<Venda>
        {
            new Venda(3, "Mouse Sem Fio", 89.90m)
        };
    }
}
