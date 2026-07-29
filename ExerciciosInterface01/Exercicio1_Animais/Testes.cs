namespace Exercicio1_Animais;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        IAnimal cachorro = new Cachorro();
        IAnimal gato = new Gato();
        IAnimal passaro = new Passaro();

        Verificar("Cachorro implementa IAnimal", cachorro is IAnimal);
        Verificar("Gato implementa IAnimal", gato is IAnimal);
        Verificar("Passaro implementa IAnimal", passaro is IAnimal);

        Console.WriteLine();
    }

    private static void Verificar(string nome, bool condicao)
    {
        Console.WriteLine(condicao ? $"[OK] {nome}" : $"[FALHOU] {nome}");
    }
}
