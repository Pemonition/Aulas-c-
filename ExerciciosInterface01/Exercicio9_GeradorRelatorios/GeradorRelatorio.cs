namespace Exercicio9_GeradorRelatorios;

// Depende apenas das interfaces (IFonteDeDados / IExportadorRelatorio), nunca de
// implementacoes concretas. Trocar a fonte de dados ou o formato de saida nao exige
// nenhuma alteracao nesta classe: basta injetar outra implementacao no construtor.
public class GeradorRelatorio
{
    private readonly IFonteDeDados _fonteDeDados;
    private readonly IExportadorRelatorio _exportador;

    public GeradorRelatorio(IFonteDeDados fonteDeDados, IExportadorRelatorio exportador)
    {
        _fonteDeDados = fonteDeDados;
        _exportador = exportador;
    }

    public void GerarRelatorioDeVendas()
    {
        List<Venda> vendas = _fonteDeDados.BuscarVendas();
        _exportador.Exportar(vendas);
    }
}
