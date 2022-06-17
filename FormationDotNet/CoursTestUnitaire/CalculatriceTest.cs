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

        //Ecrire les fonctions de tests pour la méthode civility

        [TestMethod]
        public void CivilityTest_1_MME()
        {
            Tools tools = new Tools();

            string result = tools.ConvertCivility(1);
            Assert.AreEqual("Mme.", result);
        }
        [TestMethod]
        public void CivilityTest_2_M()
        {
            Tools tools = new Tools();

            string result = tools.ConvertCivility(2);
            Assert.AreEqual("M.", result);
        }

        [TestMethod]
        public void CivilityTest_3_NULL()
        {
            Tools tools = new Tools();

            string result = tools.ConvertCivility(3);
            Assert.IsNull(result);
        }
    }
}
