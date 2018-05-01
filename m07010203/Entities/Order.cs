using System;
using System.Collections.Generic;
using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Orders]")]
    public class Order
    {
        [PrimaryKey, Identity]
        [Column("OrderID")]
        public int OrderId { get; set; }

        [Association(ThisKey = nameof(OrderId),
                     OtherKey = nameof(OrderId),
                     CanBeNull = true)]
        public IEnumerable<OrderDetails> OrderDetails { get; set; }

        [Column("CustomerID")]
        public string CustomerId { get; set; }

        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column("RequiredDate")]
        public DateTime RequiredDate { get; set; }

        [Column("ShippedDate")]
        public DateTime ShippedDate { get; set; }

        [Column("ShipVia")]
        public int ShipVia { get; set; }

        [Column("Freight")]
        public decimal Freight { get; set; }

        [Column("ShipName")]
        public string ShipName { get; set; }

        [Column("ShipAddress")]
        public string ShipAddress { get; set; }

        [Column("ShipCity")]
        public string ShipCity { get; set; }

        [Column("ShipRegion")]
        public string ShipRegion { get; set; }

        [Column("ShipPostalCode")]
        public string ShipPostalCode { get; set; }

        [Column("ShipCountry")]
        public string ShipCountry { get; set; }
    }
}
