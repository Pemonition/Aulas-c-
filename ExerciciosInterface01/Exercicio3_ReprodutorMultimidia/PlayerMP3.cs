namespace Exercicio3_ReprodutorMultimidia;

public class PlayerMP3 : IReprodutorMultimidia
{
    public void Play() => Console.WriteLine("PlayerMP3: reproduzindo faixa de audio.");
    public void Pause() => Console.WriteLine("PlayerMP3: pausado.");
    public void Stop() => Console.WriteLine("PlayerMP3: parado.");
    public void Avancar(int segundos) => Console.WriteLine($"PlayerMP3: avancando {segundos} segundos na faixa.");
}
