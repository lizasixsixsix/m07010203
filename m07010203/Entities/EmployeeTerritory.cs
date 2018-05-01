using LinqToDB.Mapping;

namespace m07010203.Entities
{
    public class EmployeeTerritory
    {
        [PrimaryKey]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [PrimaryKey]
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }
    }
}
