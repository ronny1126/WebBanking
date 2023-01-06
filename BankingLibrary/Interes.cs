using System;

namespace BankingLibrary
{
    public class Interes
    {
        public static double CalculoInteres(decimal monto, decimal tasa)
        {
            double interes = 0;
            int dias = 365;
            if (monto <= 0)
                interes = 0;
            else
                interes = (double) monto * (double) tasa / dias;
            return interes;
        }
    }
}
