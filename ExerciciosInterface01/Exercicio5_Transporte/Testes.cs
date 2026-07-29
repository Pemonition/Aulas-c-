namespace Exercicio5_Transporte;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        List<ITransporte> transportes = new List<ITransporte> { new Carro(), new Aviao(), new Trem() };

        foreach (ITransporte transporte in transportes)
        {
            Verificar($"{transporte.GetType().Name} inicia e finaliza viagem sem excecao", ExecutarSemErro(transporte));
        }

        Console.WriteLine();
    }

    private static bool ExecutarSemErro(ITransporte transporte)
    {
        try
        {
            transporte.IniciarViagem("Destino de Teste");
            transporte.FinalizarViagem();
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
