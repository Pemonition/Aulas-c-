namespace Exercicio5_Transporte;

public class Carro : ITransporte
{
    public void IniciarViagem(string destino) => Console.WriteLine($"Carro: saindo de viagem por estrada rumo a {destino}.");
    public void FinalizarViagem() => Console.WriteLine("Carro: chegou ao destino e estacionou.");
}
