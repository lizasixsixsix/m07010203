using System.Collections.Generic;

using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Territories]")]
    public class Territory
    {
        [PrimaryKey, Identity]
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }

        [Column("TerritoryDescription")]
        public string TerritoryDescription { get; set; }

        [Column("RegionID")]
        public int RegionId { get; set; }

        [Association(ThisKey = nameof(TerritoryId),
                     OtherKey = nameof(TerritoryId),
                     CanBeNull = true)]
        public IEnumerable<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
