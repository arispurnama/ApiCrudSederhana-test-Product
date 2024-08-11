using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public  string Description { get; set; }
    }
    public class ProductsRequest
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
    public class UpdateProductsRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
