namespace Exercicio6_Notificador;

public class NotificadorSMS : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
        => Console.WriteLine($"[SMS] Para: {destinatario} | Mensagem: {mensagem}");
}
