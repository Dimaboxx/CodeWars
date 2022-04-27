using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSummInt;

namespace stringintsum
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("123", "456", "579")]
        [DataRow("8797", "45", "8842")]
        [DataRow("800", "9567", "10367")]
        [DataRow("99", "1", "100")]
        [DataRow("00103", "08567", "8670")]
        [DataRow("5", "", "5")]
        [DataRow("712569312664357328695151392", "8100824045303269669937", "712577413488402631964821329")]
        [DataRow("50095301248058391139327916261", "81055900096023504197206408605", "131151201344081895336534324866")]
        public void Test_Add(string a, string b, string expected)
        {
            Assert.AreEqual(expected, StringSummInt.SummStringInt.sumStrings(a, b));
        }
        //public void TestMethod1()
        //{
        //    Assert.AreEqual("579", StringSummInt.SummStringInt.sumStrings("123", "456"));
        //}
    }
}
