namespace Exercicio8_RPG;

public class Paladino : IAtacante, ICurador, IVoador
{
    public void Atacar() => Console.WriteLine("Paladino: golpeia com a espada sagrada!");
    public void Curar() => Console.WriteLine("Paladino: abencoa os aliados e restaura vida.");
    public void Voar() => Console.WriteLine("Paladino: alca voo montado em sua montaria alada.");
}
