namespace Exercicio2_FormasGeometricas;

public class Circulo : IFormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularArea() => Math.PI * Raio * Raio;
    public double CalcularPerimetro() => 2 * Math.PI * Raio;
}
