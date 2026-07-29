namespace Exercicio8_RPG;

public class Mago : IAtacante, ICurador
{
    public void Atacar() => Console.WriteLine("Mago: lanca uma bola de fogo!");
    public void Curar() => Console.WriteLine("Mago: conjura um feitico de cura.");
}
