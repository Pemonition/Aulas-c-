namespace Exercicio3_ReprodutorMultimidia;

public class PlayerStreaming : IReprodutorMultimidia
{
    public void Play() => Console.WriteLine("PlayerStreaming: iniciando transmissao ao vivo.");
    public void Pause() => Console.WriteLine("PlayerStreaming: buffer pausado.");
    public void Stop() => Console.WriteLine("PlayerStreaming: transmissao encerrada.");
    public void Avancar(int segundos) => Console.WriteLine($"PlayerStreaming: pulando {segundos} segundos no stream.");
}
