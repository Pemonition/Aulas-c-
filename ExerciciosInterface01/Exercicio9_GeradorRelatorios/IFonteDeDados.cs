namespace Exercicio9_GeradorRelatorios;

// Abstrai de onde as vendas vem: banco de dados, arquivo texto, API externa, etc.
// O GeradorRelatorio nunca depende de uma fonte concreta, apenas desta interface.
public interface IFonteDeDados
{
    List<Venda> BuscarVendas();
}
