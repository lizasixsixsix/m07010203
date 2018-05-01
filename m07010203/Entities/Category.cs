using LinqToDB.Mapping;

namespace m07010203.Entities
{
    [Table("[Northwind].[Categories]")]
    public class Category
    {
        [PrimaryKey, Identity]
        [Column("CategoryID")]
        public int CategoryId { get; set; }

        [Column("CategoryName")]
        public string CategoryName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Picture")]
        public byte[] Picture { get; set; }
    }
}
