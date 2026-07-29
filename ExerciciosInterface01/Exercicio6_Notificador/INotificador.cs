namespace Exercicio6_Notificador;

// A interface desacopla quem dispara a notificacao do canal usado para enviar
// (e-mail, SMS, WhatsApp); um List<INotificador> permite enviar a mesma mensagem
// por todos os canais cadastrados, e novos canais entram sem mudar Program.cs.
public interface INotificador
{
    void EnviarMensagem(string destinatario, string mensagem);
}
