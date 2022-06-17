using CoursCSharpPOO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTestUnitaire
{
    [TestClass]
    public class LePenduTest
    {
        private LePendu pendu = new LePendu();
        private FakeGenerateur generateur = new FakeGenerateur();
        [TestMethod]
        public void TestCharTest_c_true()
        {
            //Act
            pendu.GenererMasque(generateur);
            bool result = pendu.TestChar('c');
            Assert.IsTrue(result);
        }

       

        [TestMethod]
        public void TestCharTest_nbEssai()
        {
            //Act
            pendu.GenererMasque(generateur);
            pendu.TestChar('t');
            pendu.TestChar('c');
            Assert.AreEqual(9, pendu.NbEssai);
        }

        [TestMethod]
        public void TestCharTest_t_false()
        {
            //Act
            pendu.GenererMasque(generateur);
            bool result = pendu.TestChar('t');
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCharTest_masque()
        {
            //Act
            pendu.GenererMasque(generateur);
            pendu.TestChar('t');
            pendu.TestChar('c');
            Assert.AreEqual("c**c**", pendu.Masque);
        }

        
    }
}
