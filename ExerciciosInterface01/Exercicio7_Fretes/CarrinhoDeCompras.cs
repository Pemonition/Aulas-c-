namespace Exercicio7_Fretes;

public class CarrinhoDeCompras
{
    public List<IFretavel> Itens { get; } = new List<IFretavel>();

    public void AdicionarItem(IFretavel item) => Itens.Add(item);

    public decimal CalcularFreteTotal(decimal distanciaKm)
    {
        decimal total = 0;
        foreach (IFretavel item in Itens)
        {
            total += item.CalcularFrete(distanciaKm);
        }
        return total;
    }
}
