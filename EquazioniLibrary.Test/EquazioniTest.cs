using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 4;
            double b = 6;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotDeterminedTest()
        {
            double a = 0;
            double b = 6;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsInconsisted()
        {
            double a = 0;
            double b = 6;
            bool risposta = Equazioni.IsInconsisted(a,b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotInconsisted()
        {
            double a = 4;
            double b = 6;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsNotDegree2Test()
        {
            double a = 0;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(false, risposta);
        }
    }
}
