namespace Exercicio2_FormasGeometricas;

public class Triangulo : IFormaGeometrica
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double ladoA, double ladoB, double ladoC, double @base, double altura)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
        Base = @base;
        Altura = altura;
    }

    public double CalcularArea() => (Base * Altura) / 2;
    public double CalcularPerimetro() => LadoA + LadoB + LadoC;
}
