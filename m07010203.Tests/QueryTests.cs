using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace m07010203.Tests
{
    [TestClass]
    public class QueryTests
    {
        [TestMethod]
        public void ProductListWithCategoryAndSupplier()
        {
            var nw = new NorthwindDB();

            Assert.IsNotNull(nw);

            var prodInfo = nw.Products.Select(
                p => new
                {
                    name = p.ProductName ?? "",
                    category = p.Category.CategoryName ?? "",
                    supplier = p.Supplier.ContactName ?? ""
                })
                .ToList();

            Assert.IsNotNull(prodInfo,
                             prodInfo
                                 .Select(i => i.name + " "
                                              + i.category + " "
                                              + i.supplier)
                                 .Aggregate((a, b) => a + "\n" + b));
        }
    }
}
