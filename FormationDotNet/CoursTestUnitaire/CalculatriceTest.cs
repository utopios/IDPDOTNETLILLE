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
        private Calculatrice calculatrice = new Calculatrice();
        [TestMethod]
        public void AdditionTest_10_20_30()
        {
            //A => Arrange
            //Calculatrice calculatrice = new Calculatrice();

            //A => Act
            int result = calculatrice.Addition(10, 20);
            //A => Assert
            Assert.AreEqual(30, result);
        }

        //Ecrire une fonction de test pour la soustraction

        [TestMethod]
        public void SoustractionTest_20_10_10()
        {
            //Calculatrice calculatrice = new Calculatrice();

            int result = calculatrice.Soustraction(20, 10);
            
            Assert.AreEqual(10, result);
        }
    }
}
