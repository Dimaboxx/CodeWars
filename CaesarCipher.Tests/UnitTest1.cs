using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       // [DataRow("aaaaa")]
        [DataRow("I should have known that you would have a perfect answer for me!!!")]   //1
        [DataRow("O CAPTAIN! my Captain! our fearful trip is done;")]  // 2
        [DataRow("abcdefghjuty1234")]    //2a
        [DataRow("O Caesar! How great you are!")]  // 3
        [DataRow("You can also become allies with other warriors by following...")] //4
       // [DataRow("Emo tin sejehqec iuj vldcom'a rlxskxh--rzb gva xkg sgmoan t-t....")]  //5
        public void TestMethod1(string input)
        {

            Assert.AreEqual(input, CaesarCipher.demovingShift(CaesarCipher.movingShift(input, 1), 1));
        }
    }
}

