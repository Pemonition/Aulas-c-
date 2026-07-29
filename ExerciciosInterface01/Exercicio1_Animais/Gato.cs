namespace Exercicio1_Animais;

public class Gato : IAnimal
{
    public void Falar() => Console.WriteLine("Gato: Miau!");
    public void Mover() => Console.WriteLine("Gato deslizando silenciosamente.");
}
