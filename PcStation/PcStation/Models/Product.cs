using System.ComponentModel.DataAnnotations;

namespace PcStation.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        [Required]
        public double price { get; set; }
    }
}
