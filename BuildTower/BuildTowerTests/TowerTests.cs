using static BuildTower.Program;

namespace BuildTowerTests
{
    [TestClass]
    public sealed class TowerTests
    {
        [TestMethod]
        public void OneFloor()
        {
            CollectionAssert.AreEqual(TowerBuilder(1), new[] {"*"});
        }

        [TestMethod]
        public void ThreeFloors()
        {
            CollectionAssert.AreEqual(TowerBuilder(3), new[] { "  *  ", " *** ", "*****"});
        }

        [TestMethod]
        public void FiveFloors()
        {
            CollectionAssert.AreEqual(TowerBuilder(5), new[] { "    *    ", "   ***   ", "  *****  ", " ******* ", "*********"});
        }
    }
}
