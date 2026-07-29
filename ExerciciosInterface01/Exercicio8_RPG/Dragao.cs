namespace Exercicio8_RPG;

public class Dragao : IAtacante, IVoador
{
    public void Atacar() => Console.WriteLine("Dragao: cospe uma baforada de fogo!");
    public void Voar() => Console.WriteLine("Dragao: alca voo com suas asas gigantes.");
}
