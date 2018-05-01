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
    }
}
