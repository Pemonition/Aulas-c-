namespace Exercicio7_Fretes;

public class ProdutoMovel : IFretavel
{
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    private const decimal ValorPorKm = 2.50m;
    private const decimal TaxaVolume = 20.00m;

    public ProdutoMovel(string nome, decimal precoBase)
    {
        Nome = nome;
        PrecoBase = precoBase;
    }

    public decimal CalcularFrete(decimal distanciaKm) => (ValorPorKm * distanciaKm) + TaxaVolume;
}
