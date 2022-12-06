using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioContaBancaria
{
    internal class Account
    {
        public int Numero { get; private set; }
        public string Titular {get; set;}
        public double Saldo { get; private set; }

        public Account(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Account(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", "
                + "Titular: "
                + Titular
                + ", "
                + "Saldo: "
                + "$ "
                + Saldo;
        }
    }
}
