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
        [Range(0,3000, ErrorMessage="Η τιμή πρέπει να είναι μεταξύ 0 και 3000!")]
        public double price { get; set; }
    }
}
