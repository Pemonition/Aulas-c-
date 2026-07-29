namespace Exercicio8_RPG;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        Dragao dragao = new Dragao();
        Mago mago = new Mago();
        Paladino paladino = new Paladino();

        Verificar("Dragao ataca e voa, mas nao cura", dragao is IAtacante && dragao is IVoador && !(dragao is ICurador));
        Verificar("Mago ataca e cura, mas nao voa", mago is IAtacante && mago is ICurador && !(mago is IVoador));
        Verificar("Paladino ataca, cura e voa", paladino is IAtacante && paladino is ICurador && paladino is IVoador);

        Console.WriteLine();
    }

    private static void Verificar(string nome, bool condicao)
    {
        Console.WriteLine(condicao ? $"[OK] {nome}" : $"[FALHOU] {nome}");
    }
}
