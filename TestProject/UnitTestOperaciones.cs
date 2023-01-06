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
            bool cuentaValida = Operaciones.abierta;

            //Act
            //LLamar al metodo de apertura de cuenta
            //cuentaValida = pendiente

            Operaciones.AperturaCuenta();

            Assert.True(cuentaValida);
        }

        [Fact]
        public void TestDeposito()
        {
            
            Operaciones.AperturaCuenta();
            Operaciones.Deposito(100);
            Assert.Equal(100, Operaciones.saldo);
        }

        [Fact(Skip = "Pendiente de implementacion")]
        public void TestRetiro()
        {
           

        }

    }
}
