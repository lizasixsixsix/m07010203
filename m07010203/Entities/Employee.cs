using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Employees]")]
    public class Employee
    {
        [PrimaryKey, Identity]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [Association(ThisKey = nameof(EmployeeId),
                     OtherKey = nameof(EmployeeId),
                     CanBeNull = true)]
        public EmployeeTerritory EmployeeTerritory { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("TitleOfCourtesy")]
        public string TitleOfCourtesy { get; set; }

        [Column("BirthDate")]
        public string BirthDate { get; set; }

        [Column("HireDate")]
        public string HireDate { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("Region")]
        public string Region { get; set; }

        [Column("PostalCode")]
        public string PostalCode { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("HomePhone")]
        public string HomePhone { get; set; }

        [Column("Extension")]
        public string Extension { get; set; }

        [Column("Photo")]
        public byte[] Photo { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("ReportsTo")]
        public int ReportsTo { get; set; }

        [Column("PhotoPath")]
        public string PhotoPath { get; set; }
    }
}
