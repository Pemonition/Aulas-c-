namespace Exercicio3_ReprodutorMultimidia;

public class PlayerVideo : IReprodutorMultimidia
{
    public void Play() => Console.WriteLine("PlayerVideo: reproduzindo video.");
    public void Pause() => Console.WriteLine("PlayerVideo: pausado.");
    public void Stop() => Console.WriteLine("PlayerVideo: parado.");
    public void Avancar(int segundos) => Console.WriteLine($"PlayerVideo: avancando {segundos} segundos no video.");
}
