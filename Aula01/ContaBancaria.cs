using System;

public class ContaBancaria
{
    public string Titular = ""; //Colocar (aspas) para permitir que "Titular" seja nulo;
    public int Numero;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
        Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
    }

    public void ExibirExtrato()
    {

        Console.WriteLine("--- EXTRATO BANCÁRIO");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"N° da Conta: {Numero}");
        Console.WriteLine($"Saldo Atual: R${Saldo}");
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("Saque realizado com Sucesso!");
        } else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
        }
    }
}