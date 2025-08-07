using static FindUnique.Program;

namespace FindUniqueTests
{
    [TestClass]
    public sealed class GetUniqueTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> testList = [1, 2, 2, 2];
            Assert.AreEqual(1, GetUnique(testList));
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> testList = [-2, 2, 2, 2];
            Assert.AreEqual(-2, GetUnique(testList));
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> testList = [11, 11, 14, 11, 11];
            Assert.AreEqual(14, GetUnique(testList));
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<int> testList = [8, 8, 8, 8, 7];
            Assert.AreEqual(7, GetUnique(testList));
        }
    }
}
