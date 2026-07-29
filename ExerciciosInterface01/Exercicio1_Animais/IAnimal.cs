namespace Exercicio1_Animais;

// Cada animal fala e se move de um jeito proprio; a interface deixa o codigo
// cliente (o foreach em Program.cs) tratar qualquer animal da mesma forma,
// sem precisar saber se e um Cachorro, um Gato ou um Passaro.
public interface IAnimal
{
    void Falar();
    void Mover();
}
