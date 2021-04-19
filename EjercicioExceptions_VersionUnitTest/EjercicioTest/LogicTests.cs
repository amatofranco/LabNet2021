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
    public class LogicTests
    {
        [TestMethod()]

        [ExpectedException(typeof(InvalidOperationException))]

        public void ThrowExceptionTest()
        {
            //act

            Logic.ThrowException();

            // assert manejado por InvalidOperationException
        }

        [TestMethod()]

        [ExpectedException(typeof(CustomException))]



        public void ThrowCustomExceptionTest()
        {
            //act

            Logic.ThrowCustomException();

            // assert manejado por InvalidOperationException
        }
    }
}