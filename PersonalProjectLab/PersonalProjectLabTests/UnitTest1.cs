using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int choice = 9;
            string expected = "Throw a Knuckleball";
            string actual = PersonalProjectLab.EmptyClass.GetPitch();

            Assert.AreEqual(expected, actual);

        }
    }
}
