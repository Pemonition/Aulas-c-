namespace Exercicio4_ProcessadorPagamento;

// Cada meio de pagamento tem sua propria integracao (operadora de cartao, PayPal,
// banco emissor de boleto); a interface permite adicionar ou trocar processadores
// sem alterar o codigo que apenas manda processar/cancelar o pagamento.
public interface IProcessadorPagamento
{
    void ProcessarPagamento(decimal valor);
    void CancelarPagamento();
}
