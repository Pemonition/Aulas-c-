namespace Exercicio2_FormasGeometricas;

public static class Testes
{
    public static void ExecutarTestes()
    {
        Console.WriteLine("--- Testes ---");

        Retangulo retangulo = new Retangulo(largura: 4, altura: 6);
        Circulo circulo = new Circulo(raio: 3);
        Triangulo triangulo = new Triangulo(ladoA: 3, ladoB: 4, ladoC: 5, @base: 4, altura: 3);

        Verificar("Retangulo.CalcularArea", retangulo.CalcularArea(), 24.0);
        Verificar("Retangulo.CalcularPerimetro", retangulo.CalcularPerimetro(), 20.0);
        Verificar("Circulo.CalcularArea", circulo.CalcularArea(), Math.PI * 9, tolerancia: 0.01);
        Verificar("Circulo.CalcularPerimetro", circulo.CalcularPerimetro(), Math.PI * 6, tolerancia: 0.01);
        Verificar("Triangulo.CalcularArea", triangulo.CalcularArea(), 6.0);
        Verificar("Triangulo.CalcularPerimetro", triangulo.CalcularPerimetro(), 12.0);

        Console.WriteLine();
    }

    private static void Verificar(string nome, double obtido, double esperado, double tolerancia = 0.001)
    {
        bool ok = Math.Abs(obtido - esperado) <= tolerancia;
        Console.WriteLine(ok
            ? $"[OK] {nome} = {obtido:F2}"
            : $"[FALHOU] {nome} = {obtido:F2} (esperado {esperado:F2})");
    }
}
