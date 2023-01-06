using System;
using Xunit;
using BankingLibrary;

namespace TestProject
{
    public class UnitTestInteres
    {
        [Fact]
        public void TestInteres1()
        {
            decimal monto = 100;
            decimal tasa = 0.2M;
            double resultado = 0;
            resultado = Interes.CalculoInteres(monto, tasa);
            Assert.Equal(0.0548, resultado, 4);

        }
        [Fact]
        public void TestInteres2()
        {
            decimal monto = 0;
            decimal tasa = 0.2M;
            double resultado = 0;
            resultado = Interes.CalculoInteres(monto, tasa);
            Assert.Equal(0, resultado, 4);

        }

        [Fact]
        public void TestInteres3()
        {
            decimal monto = -100;
            decimal tasa = 0.2M;
            double resultado = 0;
            resultado = Interes.CalculoInteres(monto, tasa);
            Assert.Equal(0, resultado, 4);

        }
    }
}
