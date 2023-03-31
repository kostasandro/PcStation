using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    [Table("Filter")]

    public class Filter
    {
        [Key]
        public int NameId { get; set; }

        public string Name { get; set; }

        public int ValueId { get; set; }

        public string Value { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
