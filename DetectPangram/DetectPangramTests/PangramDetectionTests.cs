using static DetectPangram.Program;

namespace DetectPangramTests
{
    [TestClass]
    public sealed class PangramDetectionTests
    {


        [TestMethod]
        public void PangramTest1()
        {
            Assert.IsTrue(IsPangram("The quick brown fox jumps over the lazy dog."));
        }

        [TestMethod]
        public void PangramTest2()
        {
            Assert.IsTrue(IsPangram("abcdefghijklmnopqrstuvwxyz"));
        }

        [TestMethod]
        public void PangramTest3()
        {
            Assert.IsFalse(IsPangram("cnscndcscidnbcisdbisducbdsicuhbdichdbcibsichdbibdciudbcidsuhbcdiuhcbdidcubhscicdbdiucbsib"));
        }
    }
}
