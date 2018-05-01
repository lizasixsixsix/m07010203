using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Customers]")]
    public class Customer
    {
        [PrimaryKey, Identity]
        [Column("CustomerID")]
        public string CustomerId { get; set; }

        [Column("CompanyName")]
        public string CompanyName { get; set; }

        [Column("ContactName")]
        public string ContactName { get; set; }

        [Column("ContactTitle")]
        public string ContactTitle { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("Region")]
        public string Region { get; set; }

        [Column("PostaCode")]
        public string PostalCode { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Fax")]
        public string Fax { get; set; }
    }
}
