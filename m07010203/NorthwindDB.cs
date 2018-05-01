using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;

using m07010203.Entities;

namespace m07010203
{
    public class NorthwindDB : DataConnection
    {
        public NorthwindDB() : base("Northwind")
        {
            Configuration.Linq.AllowMultipleQuery = true;
        }

        public ITable<Category> Categories => GetTable<Category>();
        public ITable<Customer> Customers => GetTable<Customer>();
        public ITable<Employee> Employees => GetTable<Employee>();
        public ITable<EmployeeTerritory> EmployeeTerritories => GetTable<EmployeeTerritory>();
        public ITable<OrderDetails> OrderDetails => GetTable<OrderDetails>();
        public ITable<Order> Orders => GetTable<Order>();
        public ITable<Product> Products => GetTable<Product>();
        public ITable<Region> Region => GetTable<Region>();
        public ITable<Shipper> Shippers => GetTable<Shipper>();
        public ITable<Supplier> Suppliers => GetTable<Supplier>();
        public ITable<Territory> Territories => GetTable<Territory>();
    }
}
