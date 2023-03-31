using ProductXmlReader;
using System.Xml.Serialization;

XmlSerializer xml = new XmlSerializer(typeof(Products));

Products products = null;
using (var stream = new FileStream("C:\\Users\\Konstantinos\\Desktop\\products.xml", FileMode.Open))
{
    products = (Products)xml.Deserialize(stream);
}


