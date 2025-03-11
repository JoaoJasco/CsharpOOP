﻿class Program
{
    static void Main(string[] args)
    {
        ContaBancaria minhaConta = new ContaBancaria();
      

        Console.WriteLine("Saldo atual: " + minhaConta.saldo());
    }
}


class ContaBancaria {
    double valor = 0;

    public void depositar (double deposito) {
        if (deposito > 0) {
            valor = valor + deposito;
        }
    }

    public void sacar (double saque) {
        if (saque <= valor)
        valor = valor - saque;
    }

    public double saldo(){
        return valor;
    }

}

