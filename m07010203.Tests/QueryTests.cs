using System;
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

        [TestCleanup]
        public void Cleanup()
        {
            this.nw.Dispose();
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

            Assert.IsTrue(prodInfo.Count() > 0);

            Console.WriteLine(prodInfo.Select(p => p.name + "\t"
                                                   + p.category + "\t"
                                                   + p.supplier)
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

            Assert.IsNotNull(emplTerr.Count() > 0);

            Console.WriteLine(emplTerr.Select(e => e.name + "\t"
                                                   + e.territory)
                                      .Aggregate((a, b) => a + "\n" + b));
        }

        [TestMethod]
        public void EmployeeAmountPerRegion()
        {
            var emplAmount = nw.Region.Select(
                r => new
                {
                    region = r.RegionDescription,
                    amount = r.Territories
                        .SelectMany(t => t.EmployeeTerritories)
                            .SelectMany(e => e.Employees)
                                .Count()
                })
                .ToList();

            Assert.IsNotNull(emplAmount.Count() > 0);

            Console.WriteLine(emplAmount.Select(r => r.region + "\t"
                                                     + r.amount)
                                        .Aggregate((a, b) => a + "\n" + b));
        }

        [TestMethod]
        public void EmployeeSuppliers()
        {
            var emplSupps = nw.Employees.Select(
                e => new
                {
                    name = e.FirstName + " " + e.LastName,
                    suppliers = e.Orders
                        .SelectMany(o => o.OrderDetails)
                            .Select(d => d.Product)
                                .Select(d => d.Supplier.ContactName)
                })
                .ToList();

            Assert.IsNotNull(emplSupps.Count() > 0);

            Console.WriteLine(emplSupps
                .Select(r => r.name + "\n"
                             + r.suppliers.Aggregate((a, b) => a + "\t" + b))
                .Aggregate((a, b) => a + "\n\n" + b));
        }
    }
}
