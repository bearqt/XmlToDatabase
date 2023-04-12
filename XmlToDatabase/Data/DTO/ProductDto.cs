using System.Xml.Serialization;

namespace XmlToDatabase.Data.Models;

[XmlType("product")]
public class ProductDto
{
    public ProductDto()
    {
        
    }

    public int Id { get; set; }
    [XmlElement("quantity")]
    public int Quantity { get; set; }
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("price")]
    public decimal Price { get; set; }
}