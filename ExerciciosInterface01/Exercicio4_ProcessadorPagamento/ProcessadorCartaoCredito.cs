namespace Exercicio4_ProcessadorPagamento;

public class ProcessadorCartaoCredito : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor) => Console.WriteLine($"Cartao de Credito: cobrando R$ {valor:F2} no cartao.");
    public void CancelarPagamento() => Console.WriteLine("Cartao de Credito: estorno solicitado junto a operadora.");
}
