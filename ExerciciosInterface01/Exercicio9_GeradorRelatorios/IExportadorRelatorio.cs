namespace Exercicio9_GeradorRelatorios;

// Abstrai o formato de saida do relatorio: PDF, CSV, JSON, etc.
// O GeradorRelatorio nunca depende de um formato concreto, apenas desta interface.
public interface IExportadorRelatorio
{
    void Exportar(List<Venda> vendas);
}
