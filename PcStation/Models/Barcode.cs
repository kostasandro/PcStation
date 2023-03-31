using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    [Table("Barcode")]
    public class Barcode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BarCode { get; set; }

        //syndeei to barcode me to product(fernei to product )
        public Product Product { get; set; }

        public bool PrimaryBarcode { get; set; }

    }
}
