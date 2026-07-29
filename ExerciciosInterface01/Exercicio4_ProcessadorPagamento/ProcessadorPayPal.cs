namespace Exercicio4_ProcessadorPagamento;

public class ProcessadorPayPal : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor) => Console.WriteLine($"PayPal: debitando R$ {valor:F2} da conta PayPal.");
    public void CancelarPagamento() => Console.WriteLine("PayPal: pagamento cancelado e valor devolvido a conta.");
}
