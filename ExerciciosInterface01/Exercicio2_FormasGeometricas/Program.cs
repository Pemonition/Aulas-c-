namespace Exercicio2_FormasGeometricas;

public static class Program
{
    public static void Main()
    {
        Testes.ExecutarTestes();

        List<IFormaGeometrica> formas = new List<IFormaGeometrica>
        {
            new Retangulo(largura: 4, altura: 6),
            new Circulo(raio: 3),
            new Triangulo(ladoA: 3, ladoB: 4, ladoC: 5, @base: 4, altura: 3)
        };

        foreach (IFormaGeometrica forma in formas)
        {
            Console.WriteLine($"{forma.GetType().Name}: Area = {forma.CalcularArea():F2}, Perimetro = {forma.CalcularPerimetro():F2}");
        }
    }
}
