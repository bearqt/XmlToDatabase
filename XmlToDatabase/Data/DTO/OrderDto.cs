using System.Xml.Serialization;

namespace XmlToDatabase.Data.Models;

[XmlType("order")]
public class OrderDto
{
    [XmlElement("no")]
    public int Id { get; set; }
    [XmlElement("reg_date")]
    public DateOnly RegDate{ get; set; }
    [XmlElement("sum")]
    public decimal Sum { get; set; }
    [XmlElement("product")]
    public ProductDto[] Products { get; set; }
    [XmlElement("user")]
    public UserDto UserDto { get; set; }
}