namespace Exercicio3_ReprodutorMultimidia;

// MP3, video e streaming atendem aos mesmos comandos (Play/Pause/Stop/Avancar)
// com implementacao interna diferente; a interface padroniza um "controle remoto"
// comum para qualquer player, permitindo trocar o tipo sem mudar quem o controla.
public interface IReprodutorMultimidia
{
    void Play();
    void Pause();
    void Stop();
    void Avancar(int segundos);
}
