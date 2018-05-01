using System.Collections.Generic;

using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Region]")]
    public class Region
    {
        [PrimaryKey, Identity]
        [Column("RegionID")]
        public int RegionId { get; set; }

        [Column("RegionDescription")]
        public string RegionDescription { get; set; }

        [Association(ThisKey = nameof(RegionId),
                     OtherKey = nameof(RegionId),
                     CanBeNull = true)]
        public IEnumerable<Territory> Territories { get; set; }
    }
}
