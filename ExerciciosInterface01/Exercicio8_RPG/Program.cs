namespace Exercicio8_RPG;

public static class Program
{
    public static void Main()
    {
        Dragao dragao = new Dragao();
        Mago mago = new Mago();
        Paladino paladino = new Paladino();

        // Cada personagem so implementa as interfaces das habilidades que realmente possui:
        // o Mago, por exemplo, nao implementa IVoador porque nao consegue voar.
        List<IAtacante> atacantes = new List<IAtacante> { dragao, mago, paladino };
        ExecutarAtaqueEmLote(atacantes);

        Console.WriteLine();
        dragao.Voar();
        mago.Curar();
        paladino.Curar();
        paladino.Voar();
    }

    private static void ExecutarAtaqueEmLote(List<IAtacante> atacantes)
    {
        foreach (IAtacante atacante in atacantes)
        {
            atacante.Atacar();
        }
    }
}
