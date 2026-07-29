namespace Exercicio4_ProcessadorPagamento;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        List<IProcessadorPagamento> processadores = new List<IProcessadorPagamento>
        {
            new ProcessadorCartaoCredito(),
            new ProcessadorPayPal(),
            new ProcessadorBoleto()
        };

        foreach (IProcessadorPagamento processador in processadores)
        {
            processador.ProcessarPagamento(150.90m);
            processador.CancelarPagamento();
            Console.WriteLine();
        }
    }
}
