namespace Exercicio6_Notificador;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        List<INotificador> canais = new List<INotificador>
        {
            new NotificadorEmail(),
            new NotificadorSMS(),
            new NotificadorWhatsApp()
        };

        string destinatario = "cliente@teste.com";
        string mensagemTeste = "Sua presenca no evento foi confirmada!";

        foreach (INotificador canal in canais)
        {
            canal.EnviarMensagem(destinatario, mensagemTeste);
        }
    }
}
