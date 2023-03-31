
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{

    [Table("Image")]

    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string Thumb { get; set; }

        public string Image1 { get; set; }

        public ICollection<ProductImages> ProductImages { get; set; }

    }
}
