namespace Exercicio7_Fretes;

// Cada categoria de produto calcula o frete com uma regra propria (fixo, por Km,
// por Km + taxa); a interface permite ao CarrinhoDeCompras somar o frete de itens
// heterogeneos sem conhecer a regra especifica de cada categoria.
public interface IFretavel
{
    decimal CalcularFrete(decimal distanciaKm);
}
