namespace Exercicio5_Transporte;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        List<ITransporte> transportes = new List<ITransporte> { new Carro(), new Aviao(), new Trem() };

        foreach (ITransporte transporte in transportes)
        {
            transporte.IniciarViagem("Blumenau");
            transporte.FinalizarViagem();
            Console.WriteLine();
        }
    }
}
