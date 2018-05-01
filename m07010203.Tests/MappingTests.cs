using m07010203.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace m07010203.Tests
{
    [TestClass]
    public class MappingTests
    {
        [TestMethod]
        public void MappingSucceeeded()
        {
            var nw = new NorthwindDB();

            Assert.AreEqual(typeof(Category), nw.Categories.ElementType);
        }
    }
}
