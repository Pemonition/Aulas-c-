namespace Exercicio5_Transporte;

public class Aviao : ITransporte
{
    public void IniciarViagem(string destino) => Console.WriteLine($"Aviao: decolando rumo a {destino}.");
    public void FinalizarViagem() => Console.WriteLine("Aviao: pousou e taxiou ate o portao.");
}
