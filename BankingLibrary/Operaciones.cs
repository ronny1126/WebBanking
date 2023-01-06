using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary
{
    public static class Operaciones
    {
        public static string cuenta { get; set; }
        public static double? saldo { get; set; }
        public static bool abierta { get; set; } = false;
        public static void AperturaCuenta()
        {
            cuenta = "1001";
            saldo = 0;
            abierta = true;
        }
        public static void Deposito(double valor)
        {
            saldo += valor;
        }
        public static void Retiro(double valor)
        {
            saldo -= valor;
        }
    }
}
