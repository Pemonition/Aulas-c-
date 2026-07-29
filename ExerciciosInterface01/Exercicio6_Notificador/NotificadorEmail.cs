namespace Exercicio6_Notificador;

public class NotificadorEmail : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
        => Console.WriteLine($"[E-mail] Para: {destinatario} | Mensagem: {mensagem}");
}
