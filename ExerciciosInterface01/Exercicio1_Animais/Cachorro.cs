namespace Exercicio1_Animais;

public class Cachorro : IAnimal
{
    public void Falar() => Console.WriteLine("Cachorro: Au au!");
    public void Mover() => Console.WriteLine("Cachorro correndo com as quatro patas.");
}
