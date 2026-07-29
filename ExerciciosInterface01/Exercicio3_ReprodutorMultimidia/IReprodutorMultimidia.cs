namespace Exercicio3_ReprodutorMultimidia;

public interface IReprodutorMultimidia
{
    void Play();
    void Pause();
    void Stop();
    void Avancar(int segundos);
}
