using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalProjectLabTests
{   
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            string expected = "Throw a Knuckleball";
            string actual = PersonalProjectLab.EmptyClass.GetPitch(9);

            Assert.AreEqual(expected, actual);

        }
    }
}
