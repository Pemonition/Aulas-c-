namespace Exercicio1_Animais;

public static class Program
{
    public static void Main()
    {
        List<IAnimal> animais = new List<IAnimal> { new Cachorro(), new Gato(), new Passaro() };

        foreach (IAnimal animal in animais)
        {
            animal.Falar();
            animal.Mover();
        }
    }
}
