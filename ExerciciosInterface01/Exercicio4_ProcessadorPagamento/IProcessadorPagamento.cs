namespace Exercicio4_ProcessadorPagamento;

public interface IProcessadorPagamento
{
    void ProcessarPagamento(decimal valor);
    void CancelarPagamento();
}
