namespace Exercicio1_Animais;

public class Passaro : IAnimal
{
    public void Falar() => Console.WriteLine("Passaro: Piu piu!");
    public void Mover() => Console.WriteLine("Passaro voando pelo ceu.");
}
