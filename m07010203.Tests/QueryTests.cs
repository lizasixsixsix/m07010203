using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace m07010203.Tests
{
    [TestClass]
    public class QueryTests
    {
        private NorthwindDB nw;

        [TestInitialize]
        public void Initialize()
        {
            this.nw = new NorthwindDB();
        }

        [TestMethod]
        public void ProductListWithCategoryAndSupplier()
        {
            var prodInfo = nw.Products.Select(
                p => new
                {
                    name = p.ProductName,
                    category = p.Category.CategoryName,
                    supplier = p.Supplier.ContactName
                })
                .ToList();

            Assert.IsTrue(prodInfo.Count() > 0,
                             prodInfo
                                 .Select(i => i.name + " "
                                              + i.category + " "
                                              + i.supplier)
                                 .Aggregate((a, b) => a + "\n" + b));
        }

        [TestMethod]
        public void EmployeeListWithEmployeeTerritory()
        {
            var emplTerr = nw.Employees.Select(
                e => new
                {
                    name = e.FirstName + " " + e.LastName,
                    territory = e.EmployeeTerritory.Territory.TerritoryDescription
                })
                .ToList();

            Assert.IsNotNull(emplTerr.Count() > 0,
                             emplTerr
                                 .Select(i => i.name + " "
                                              + i.territory)
                                 .Aggregate((a, b) => a + "\n" + b));
        }
    }
}
