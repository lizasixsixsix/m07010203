using System.Collections.Generic;

using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[EmployeeTerritories]")]
    public class EmployeeTerritory
    {
        [PrimaryKey]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [PrimaryKey]
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }

        [Association(ThisKey = nameof(TerritoryId),
                     OtherKey = nameof(TerritoryId),
                     CanBeNull = true)]
        public Territory Territory { get; set; }

        [Association(ThisKey = nameof(EmployeeId),
                     OtherKey = nameof(EmployeeId),
                     CanBeNull = true)]
        public IEnumerable<Employee> Employees { get; set; }
    }
}
