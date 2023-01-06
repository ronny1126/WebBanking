using System;
using Xunit;
using BankingLibrary;

namespace TestProject
{
    public class UnitTestOperaciones
    {
        [Fact]
        public void TestAperturaCuentas()
        {
            //Arrange
            bool cuentaValida = true;

            //Act
            //LLamar al metodo de apertura de cuenta
            //cuentaValida = pendiente

            Assert.True(cuentaValida);
        }

        [Fact]
        public void TestDeposito()
        {
            Operaciones nuevaCuenta = new Operaciones();
            nuevaCuenta.AperturaCuenta();
            nuevaCuenta.Deposito(100);
            Assert.Equal(100, nuevaCuenta.saldo);
        }

        [Fact(Skip = "Pendiente de implementacion")]
        public void TestRetiro()
        {
           

        }

    }
}
