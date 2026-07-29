namespace Exercicio6_Notificador;

public class NotificadorWhatsApp : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
        => Console.WriteLine($"[WhatsApp] Para: {destinatario} | Mensagem: {mensagem}");
}
