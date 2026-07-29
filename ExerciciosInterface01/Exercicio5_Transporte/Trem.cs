namespace Exercicio5_Transporte;

public class Trem : ITransporte
{
    public void IniciarViagem(string destino) => Console.WriteLine($"Trem: partindo dos trilhos rumo a {destino}.");
    public void FinalizarViagem() => Console.WriteLine("Trem: chegou a estacao final.");
}
