namespace Exercicio5_Transporte;

// Carro, aviao e trem iniciam e finalizam uma viagem de formas bem diferentes
// (estrada, voo, trilhos); a interface permite tratar qualquer meio de transporte
// de forma uniforme em uma lista, sem um if/else por tipo.
public interface ITransporte
{
    void IniciarViagem(string destino);
    void FinalizarViagem();
}
