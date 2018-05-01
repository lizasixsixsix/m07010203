using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Suppliers]")]
    public class Territory
    {
        [PrimaryKey, Identity]
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }

        [Column("TerritoryDescription")]
        public string TerritoryDescription { get; set; }

        [Column("RegionID")]
        public int RegionId { get; set; }
    }
}
