using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    [Table("Group")]

    public class Group
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}
