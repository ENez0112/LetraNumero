using LetraNumero.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLiterales
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 5;
            string esperado = "CINCO PESOS 00 /100";
            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int a = 15;
            string esperado = "QUINCE PESOS 00 /100";
            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int a = 150;
            string esperado = "CIENTO CINCUENTA PESOS 00 /100";
            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int a = 1500;
            string esperado = "MIL QUINIENTOS PESOS 00 /100";
            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
