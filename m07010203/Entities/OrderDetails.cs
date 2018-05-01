using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Order Details]")]
    public class OrderDetails
    {
        [PrimaryKey]
        [Column("OrderID")]
        public int OrderId { get; set; }

        [PrimaryKey]
        [Column("ProductID")]
        public int ProductId { get; set; }

        [Association(ThisKey = nameof(ProductId),
                     OtherKey = nameof(ProductId),
                     CanBeNull = true)]
        public Product Product { get; set; }

        [Column("UnitPrice")]
        public decimal UnitPrice { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("Discount")]
        public double Discount { get; set; }
    }
}
