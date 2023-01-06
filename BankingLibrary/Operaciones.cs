using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary
{
    public class Operaciones
    {
        public string cuenta { get; set; }
        public double saldo { get; set; }
        public void AperturaCuenta()
        {
            cuenta = "1001";
        }
        public void Deposito(double valor)
        {
            saldo += valor;
        }
        public void Retiro(double valor)
        {
            saldo -= valor;
        }
    }
}
