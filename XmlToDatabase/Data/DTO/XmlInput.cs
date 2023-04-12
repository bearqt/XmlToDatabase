using System.Xml.Serialization;

namespace XmlToDatabase.Data.Models;

[XmlRoot("orders")]
public class XmlInput
{

    [XmlElement("order")]
    public OrderDto[] OrdersArray { get; set; }
}