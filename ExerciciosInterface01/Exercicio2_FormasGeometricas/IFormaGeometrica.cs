namespace Exercicio2_FormasGeometricas;

// Cada forma calcula area e perimetro com uma formula propria; a interface
// permite guardar Retangulo, Circulo e Triangulo na mesma lista e somar/comparar
// os resultados sem um if/else para cada tipo concreto.
public interface IFormaGeometrica
{
    double CalcularArea();
    double CalcularPerimetro();
}
