namespace Exercicio4_ProcessadorPagamento;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        List<IProcessadorPagamento> processadores = new List<IProcessadorPagamento>
        {
            new ProcessadorCartaoCredito(),
            new ProcessadorPayPal(),
            new ProcessadorBoleto()
        };

        foreach (IProcessadorPagamento processador in processadores)
        {
            Verificar($"{processador.GetType().Name} processa e cancela sem excecao", ExecutarSemErro(processador));
        }

        Console.WriteLine();
    }

    private static bool ExecutarSemErro(IProcessadorPagamento processador)
    {
        try
        {
            processador.ProcessarPagamento(10m);
            processador.CancelarPagamento();
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
