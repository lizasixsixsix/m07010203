using Microsoft.VisualStudio.TestTools.UnitTesting;

using m07010203.Entities;

namespace m07010203.Tests
{
    [TestClass]
    public class MappingTests
    {
        [TestMethod]
        public void MappingSucceeded()
        {
            using (var nw = new NorthwindDB())
            {
                Assert.AreEqual(typeof(Category), nw.Categories.ElementType);
            }
        }
    }
}
