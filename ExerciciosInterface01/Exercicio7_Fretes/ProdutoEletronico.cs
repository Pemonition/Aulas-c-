namespace Exercicio7_Fretes;

public class ProdutoEletronico : IFretavel
{
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    private const decimal ValorPorKm = 1.00m;

    public ProdutoEletronico(string nome, decimal precoBase)
    {
        Nome = nome;
        PrecoBase = precoBase;
    }

    public decimal CalcularFrete(decimal distanciaKm) => ValorPorKm * distanciaKm;
}
