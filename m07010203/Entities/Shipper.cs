using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Shippers]")]
    public class Shipper
    {
        [PrimaryKey, Identity]
        [Column("ShipperID")]
        public int ShipperId { get; set; }

        [Column("CompanyName")]
        public string CompanyName { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }
    }
}
