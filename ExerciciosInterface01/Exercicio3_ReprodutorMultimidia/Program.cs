namespace Exercicio3_ReprodutorMultimidia;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        List<IReprodutorMultimidia> players = new List<IReprodutorMultimidia>
        {
            new PlayerMP3(),
            new PlayerVideo(),
            new PlayerStreaming()
        };

        foreach (IReprodutorMultimidia player in players)
        {
            player.Play();
            player.Avancar(30);
            player.Pause();
            player.Stop();
            Console.WriteLine();
        }
    }
}
