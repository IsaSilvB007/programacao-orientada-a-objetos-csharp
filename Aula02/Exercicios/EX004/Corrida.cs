namespace EX004;

public class Corrida
{
    public Passageiro passageiro;
    public Motorista motorista;


    public double distanciaKm;
    public double taxaBase;
    public string status = "Aguardando Motorista";
    public double valorFinal;

    public double CalcularValorFinal(double tempoMinutos)
    {
        valorFinal = taxaBase + (distanciaKm * 2.0) + (tempoMinutos * 0.50);
        return valorFinal;
    }
}