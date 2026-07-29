namespace Exercicio6_Notificador;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        List<INotificador> canais = new List<INotificador>
        {
            new NotificadorEmail(),
            new NotificadorSMS(),
            new NotificadorWhatsApp()
        };

        Verificar("Existem 3 canais de notificacao cadastrados", canais.Count == 3);

        foreach (INotificador canal in canais)
        {
            Verificar($"{canal.GetType().Name} envia mensagem sem excecao", EnviarSemErro(canal));
        }

        Console.WriteLine();
    }

    private static bool EnviarSemErro(INotificador canal)
    {
        try
        {
            canal.EnviarMensagem("teste@teste.com", "Mensagem de teste");
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
