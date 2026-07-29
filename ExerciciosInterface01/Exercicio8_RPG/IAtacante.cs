namespace Exercicio8_RPG;

// Habilidades separadas em interfaces pequenas (Atacar, Curar, Voar) evitam
// obrigar uma classe a implementar uma habilidade que ela nao possui -
// o Mago, por exemplo, nao implementa IVoador porque nao consegue voar.
public interface IAtacante
{
    void Atacar();
}
