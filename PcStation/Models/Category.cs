
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    [Table("Category")]

    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }


        public Group Group { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
