using CoursCSharpPOO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTestUnitaire
{
    [TestClass]
    public class CalculatriceTest
    {
        [TestMethod]
        public void TestAddition()
        {
            //A => Arrange
            Calculatrice calculatrice = new Calculatrice();

            //A => Act
            int result = calculatrice.Addition(10, 20);
            //A => Assert
            Assert.AreEqual(30, result);
        }
    }
}
