using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ProductXmlReader
{
    [Serializable]
    [XmlRoot("products")]
    public class Products
    {
        [XmlElement("product")]
        public List<Product> ProductList { get; set; }
    }
   
    [Serializable]
    [XmlRoot("product")]
    public class Product
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("sku")]
        public string Sku { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
        
        [XmlElement("barcode")]
        public string Barcode { get; set; }
        
        [XmlElement("morebarcodes")]
        public MoreBarcodes Morebarcodes { get; set; } 

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        [XmlElement("descr")]
        public string Descr { get; set; }

        [XmlElement("availability")]
        public int Availability { get; set; }

        [XmlElement("dim1")]
        public double Dim1 { get; set; }

        [XmlElement("dim2")]
        public double Dim2 { get; set; }

        [XmlElement("dim3")]
        public double Dim3 { get; set; }

        [XmlElement("weight")]
        public double Weight { get; set; }

        [XmlElement("tax")]
        public double Tax { get; set; }

        [XmlElement("stock_indicator")]
        public int Stock_indicator { get; set; }

        [XmlElement("stock")]
        public int Stock { get; set; }

        [XmlElement("minimum_quantity_to_order")]
        public int Minimum_quantity_to_order { get; set; }

        [XmlElement("RRP")]
        public double Rrp{ get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("thumb")]
        public string Thumb { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("volume")]
        public double Volume { get; set; }

        [XmlElement("courier_weight")]
        public double Courier_weight { get; set; }

        [XmlElement("in_offer")]
        public int In_offer { get; set; }

        [XmlElement("group")]
        public Group Group { get; set; }//k


        [XmlElement("gallery")]
        public Gallery Gallery { get; set; }//k

        [XmlElement("filters")]
        public Filters Filters { get; set; }//k

        [XmlElement("price")]
        public double Price { get; set; }

        [XmlElement("price_without_offer")]
        public double Price_without_offer { get; set; }

        [XmlElement("retail_percent")]
        public int Retail_percent { get; set; }

        [XmlElement("retail_price")]
        public double Retail_price { get; set; }

        [XmlElement("vat")]
        public int Vat { get; set; }

        [XmlElement("pp")]
        public int Pp { get; set; }
    }

    [Serializable]
    [XmlRoot("group")]
    public class Group
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
       
        [XmlElement("category")]
        public Category Category { get; set; }
    }

    [Serializable]
    [XmlRoot("category")]
    public class Category
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("subcategory")]
        public Subcategory Subcategory { get; set; }

    }

    [Serializable]
    [XmlRoot("subcategory")]
    public class Subcategory
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

    }

    [Serializable]
    [XmlRoot("gallery")]
    public class Gallery
    {
        [XmlElement("image")]
        public Image Image { get; set; }

    }

    [Serializable]
    [XmlRoot("image")]
    public class Image
    {
        [XmlElement("thumb")]
        public string Thumb { get; set; }
        
        [XmlElement("image")]
        public string Image1 { get; set; }

    }
    
    [Serializable]
    [XmlRoot("filters")]
    public class Filters
    {
        [XmlElement("filter")]
        public List<Filter> FilterList { get; set; }
    }


    [Serializable]
    [XmlRoot("filter")]
    public class Filter
    {
        [XmlElement("name_id")]
        public int Name_id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("value_id")]
        public int Value_id { get; set; }

        [XmlElement("value")]
        public string Value { get; set; }

    }


    [Serializable]
    [XmlRoot("morebarcodes")]
    public class MoreBarcodes
    {
        [XmlElement("barcode")]
        public List<string> Barcodes { get; set; }
    }


  
}
