using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcStation.Models
{
    [Table("Product")]

    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Sku { get; set; }

        public string Name { get; set; }


        //fernei mia lista apo barcode pou aneikoun se ena product
        public ICollection<Barcode> Barcodes { get; set; }

      

        //enwsi product me Group, category, subcategory
        public ICollection<Group> Groups { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }


        public string Manufacturer { get; set; }

        public string Descr { get; set; }

        public int Availability { get; set; }

        public double Dim1 { get; set; }

        public double Dim2 { get; set; }

        public double Dim3 { get; set; }

        public double Weight { get; set; }

        public double Tax { get; set; }

        public int StockIndicator { get; set; }

        public int Stock { get; set; }

        public int MinimumQuantityToOrder { get; set; }

        public double Rrp { get; set; }

        public string Url { get; set; }

      

        public double Volume { get; set; }

        public double Courier_weight { get; set; }

        public int InOffer { get; set; }



        //public Gallery Gallery { get; set; }//k

        public ICollection<ProductImages> ProductImages { get; set; }


        public ICollection<Filter> Filters { get; set; }


        public double Price { get; set; }

        public double PriceWithoutOffer { get; set; }

        public int RetailPercent { get; set; }

        public double RetailPrice { get; set; }

        public int Vat { get; set; }

        public int Pp { get; set; }
    }
}
