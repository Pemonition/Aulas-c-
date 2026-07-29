namespace Exercicio4_ProcessadorPagamento;

public class ProcessadorBoleto : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor) => Console.WriteLine($"Boleto: gerando boleto no valor de R$ {valor:F2}.");
    public void CancelarPagamento() => Console.WriteLine("Boleto: boleto cancelado antes do vencimento.");
}
