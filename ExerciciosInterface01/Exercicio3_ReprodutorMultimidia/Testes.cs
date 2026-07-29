namespace Exercicio3_ReprodutorMultimidia;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        IReprodutorMultimidia mp3 = new PlayerMP3();
        IReprodutorMultimidia video = new PlayerVideo();
        IReprodutorMultimidia streaming = new PlayerStreaming();

        Verificar("PlayerMP3 implementa IReprodutorMultimidia", mp3 is IReprodutorMultimidia);
        Verificar("PlayerVideo implementa IReprodutorMultimidia", video is IReprodutorMultimidia);
        Verificar("PlayerStreaming implementa IReprodutorMultimidia", streaming is IReprodutorMultimidia);
        Verificar("Comandos nao lancam excecao", ExecutarSemErro(mp3) && ExecutarSemErro(video) && ExecutarSemErro(streaming));

        Console.WriteLine();
    }

    private static bool ExecutarSemErro(IReprodutorMultimidia player)
    {
        try
        {
            player.Play();
            player.Avancar(10);
            player.Pause();
            player.Stop();
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
