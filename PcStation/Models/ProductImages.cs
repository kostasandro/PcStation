
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }
        public Image Image { get; set; }

        public Product Product { get; set; }

        public bool PrimaryImage { get; set; }

    }
}
