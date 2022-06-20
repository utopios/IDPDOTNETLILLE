using Bowling.Classes;
using Bowling.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTest
{
    [TestClass]
    public class FrameTest
    {
        private IGenerator _generator = Mock.Of<IGenerator>();
        private Frame frame;

        [TestMethod]
        public void Roll_SimpleFrame_FirstRoll_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(6);
            frame = new Frame(_generator, false);
            frame.Roll();
            Assert.AreEqual(6, frame.Score);
        }

        [TestMethod]
        public void Roll_SimpleFrame_SecondRoll_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r = new Roll(6);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r };
            frame.Roll();
            Assert.AreEqual(9, frame.Score);
        }

        [TestMethod]
        public void Roll_SimpleFrame_SecondRoll_FirstRollStrick_ReturnFalse()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r = new Roll(10);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r };
            bool result = frame.Roll();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Roll_SimpleFrame_MoreRolls_ReturnFalse()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(4);
            Roll r2 = new Roll(4);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2 };
            bool result = frame.Roll();
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Roll_LastFrame_SecondRoll_FirstRollStrick_ReturnTrue()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r = new Roll(10);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r };
            bool result = frame.Roll();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Roll_LastFrame_SecondRoll_FirstRollStrick_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r = new Roll(10);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r };
            frame.Roll();
            Assert.AreEqual(13, frame.Score);
        }

        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_FirstRollStrick_ReturnTrue()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(10);
            Roll r2 = new Roll(3);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2 };
            bool result = frame.Roll();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_FirstRollStrick_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(10);
            Roll r2 = new Roll(3);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2 };
            frame.Roll();
            Assert.AreEqual(16, frame.Score);
        }

        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_Spare_ReturnTrue()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(7);
            Roll r2 = new Roll(3);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2 };
            bool result = frame.Roll();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_Spare_CheckScore()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(7);
            Roll r2 = new Roll(3);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2 };
            frame.Roll();
            Assert.AreEqual(16, frame.Score);
        }

        [TestMethod]
        public void Roll_LastFrame_FourthRoll_ReturnFalse()
        {
            Mock.Get(_generator).Setup(m => m.RandomPins(10)).Returns(3);
            Roll r1 = new Roll(7);
            Roll r2 = new Roll(3);
            Roll r3 = new Roll(10);
            frame = new Frame(_generator, false);
            frame.Rolls = new List<Roll>() { r1, r2, r3 };
            bool result = frame.Roll();
            Assert.IsFalse(result);
        }
    }
}
