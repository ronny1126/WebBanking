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
            //Arrage
            bool cuentaValida = false;

            //Act
            Operaciones.AperturaCuenta();
            cuentaValida = Operaciones.abierta;
            //LLamar al metodo de apertura de cuenta

            //Assert
            Assert.True(cuentaValida);
            //Assert.True(Operaciones.abierta);
        }

        [Fact]
        public void TestDeposito()
        {
            
            Operaciones.AperturaCuenta();
            Operaciones.Deposito(100);
            Assert.Equal(100, Operaciones.saldo);
        }

        [Fact]
        public void TestRetiro()
        {
            Operaciones.AperturaCuenta();
            Operaciones.Deposito(100);
            Operaciones.Retiro(20);
            Assert.Equal(80, Operaciones.saldo);
        }

        [Fact]
        public void TestRetiroSobregiroNopermitido()
        {
            //Verificar si el saldo se sobregiro
            bool sobregiro = false;
            try
            {
                Operaciones.AperturaCuenta();
                Operaciones.Deposito(20);
                Operaciones.Retiro(100);
                if (Operaciones.saldo < 0)
                    sobregiro = true;
                Assert.False(sobregiro);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
           
        }

        [Fact]
        public void TestRetiroExcepcionporSobregiro()
        {
            Operaciones.AperturaCuenta();
            Operaciones.Deposito(20);
            Assert.Throws<ArgumentException>(()=>Operaciones.Retiro(100));

        }

        [Fact]
        public void TestRetiroCantidadCeroNoPermitido()
        {
            int? cantidadMovimientosAntes = 0;
            try
            {
                Operaciones.AperturaCuenta();
                Operaciones.Deposito(100);
                cantidadMovimientosAntes = Operaciones.movimientos;
                Operaciones.Retiro(0);
                Assert.Equal(cantidadMovimientosAntes, Operaciones.movimientos);
            }
            catch (Exception)
            {
                Assert.True(true); //Se presento la excepcion de valor menor o igual a cero
            }
            
        }

        [Fact]
        public void TestSaldo()
        {
            Operaciones.AperturaCuenta();
            Operaciones.Deposito(100);
            Operaciones.Retiro(100);
            Assert.Equal(0, Operaciones.saldo);
        }

    }
}
