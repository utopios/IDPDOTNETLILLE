using CoursCSharpPOO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTestUnitaire
{
    [TestClass]
    public class ToolsTest
    {
        private Tools tools = new Tools();

        //Ecrire les fonctions de tests pour la méthode civility

        [TestMethod]
        public void CivilityTest_1_MME()
        {
            //Tools tools = new Tools();

            string result = tools.ConvertCivility(1);
            Assert.AreEqual("Mme.", result);
        }
        [TestMethod]
        public void CivilityTest_2_M()
        {
            //Tools tools = new Tools();

            string result = tools.ConvertCivility(2);
            Assert.AreEqual("M.", result);
        }

        [TestMethod]
        public void CivilityTest_3_NULL()
        {
            //Tools tools = new Tools();

            string result = tools.ConvertCivility(3);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetElementTest_6_e6()
        {
            tools = new Tools(new FakeDice());
            string result = tools.GetElement();

            Assert.AreEqual("e6", result);
        }
    }
}
