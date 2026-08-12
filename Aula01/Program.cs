using System;

ContaBancaria conta = new ContaBancaria();

conta.Titular = "Isadora";
conta.Numero = 9012007;
conta.Saldo = 50.0;

conta.Depositar(150.0);
conta.ExibirExtrato();
conta.Sacar(100.0);
conta.ExibirExtrato();

ContaBancaria conta2 = new ContaBancaria();

conta2.Titular = "Maria";
conta2.Numero = 26101968;
conta2.Saldo = 700.0;

conta2.Depositar(150.0);
conta2.ExibirExtrato();
conta2.Sacar(1000.0);
conta2.ExibirExtrato();