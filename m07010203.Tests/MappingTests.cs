using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace m07010203.Tests
{
    [TestClass]
    public class MappingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nw = new NorthwindDB();

            Assert.IsNotNull(nw);

            Assert.IsNotNull(nw.Categories);
        }
    }
}
