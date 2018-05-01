using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Products]")]
    public class Product
    {
        [PrimaryKey, Identity]
        [Column("ProductID")]
        public string ProductId { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("ProductID")]
        public int CustomerId { get; set; }

        [Column("SupplierID")]
        public int SupplierId { get; set; }

        [Association(ThisKey = nameof(SupplierId),
                     OtherKey = nameof(SupplierId),
                     CanBeNull = true)]
        public Supplier Supplier { get; set; }

        [Column("CategoryID")]
        public int CategoryId { get; set; }

        [Association(ThisKey = nameof(CategoryId),
                     OtherKey = nameof(CategoryId),
                     CanBeNull = true)]
        public Category Category { get; set; }

        [Column("QuantityPerUnit")]
        public string QuantityPerUnit { get; set; }

        [Column("UnitPrice")]
        public decimal UnitPrice { get; set; }

        [Column("UnitsInStock")]
        public int UnitsInStock { get; set; }

        [Column("UnitsOnOrder")]
        public int UnitsOnOrder { get; set; }

        [Column("ReorderLevel")]
        public int ReorderLevel { get; set; }

        [Column("Discontinued")]
        public bool? Discontinued { get; set; }
    }
}
