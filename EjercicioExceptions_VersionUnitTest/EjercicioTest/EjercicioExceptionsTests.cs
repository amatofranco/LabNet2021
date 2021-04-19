using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions.Tests
{
    [TestClass()]
    public class EjercicioExceptionsTests
    {
        [TestMethod()]
        public void divisionUnoTest() // division con resultado esperado
        {
            // arrange
            int numero1 = 10;
            int numero2 = 5;
            double resultado;
            double resultadoEsperado = 2;

            // act

            resultado = EjercicioExceptions.divisionUno(numero1, numero2);

            // assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]

        [ExpectedException(typeof(DivideByZeroException))]

        public void divisionUnoTest_DividePorCero() // Error de division por 0
        {
            // arrange
            int numero1 = 10;
            int numero2 = 0;
            double resultado;
            // act
            resultado = EjercicioExceptions.divisionUno(numero1, numero2);
            // assert manejado por la exception

        }

        [TestMethod()]

        public void divisionDosTest() // division con validacion y resultado esperado
        {

            //arrange
            string numero1 = "20";
            string numero2 = "10";
            double resultado;
            double resultadoEsperado = 2;

            //act
            resultado = EjercicioExceptions.divisionDos(numero1, numero2);

            //assert
            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [TestMethod()]

        [ExpectedException(typeof(FormatException))] // se ingresa un valor que no es un numero

        public void divisionDosTest_NumeroInvalido()
        {

            //arrange
            string numero1 = "3";
            string numero2 = "";
            //act
            EjercicioExceptions.divisionDos(numero1, numero2);

            //assert manejado por FormatException

        }

        [TestMethod]

        [ExpectedException(typeof(DivideByZeroException))]

        public void divisionDosTest_DividePorCero() // se validan los numeros pero se produce error al realizar division por 0
        {
            //arrange
            string numero1 = "3";
            string numero2 = "0";
            
            //act
            EjercicioExceptions.divisionDos(numero1, numero2);
            
            //assert manejado por DivideByZeroException
        }
    }
}