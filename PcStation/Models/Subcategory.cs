using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace PcStation.Models
{
    [Table("Subcategory")]

    public class Subcategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }


        //dika mou

        public ICollection<Product> Products { get; set; }


    }
}
