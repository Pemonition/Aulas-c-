namespace Exercicio7_Fretes;

public class ProdutoLivro : IFretavel
{
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    private const decimal FreteFixo = 5.00m;

    public ProdutoLivro(string nome, decimal precoBase)
    {
        Nome = nome;
        PrecoBase = precoBase;
    }

    public decimal CalcularFrete(decimal distanciaKm) => FreteFixo;
}
