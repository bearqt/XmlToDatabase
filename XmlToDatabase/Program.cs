using System.Xml.Serialization;
using XmlToDatabase.Data.Models;
using XmlToDatabase.Services;

var xmlSerializer = new XmlSerializer(typeof(XmlInput));

await using var fs = new FileStream("Data/data.xml", FileMode.Open);

var result = xmlSerializer.Deserialize(fs) as XmlInput ?? throw new InvalidOperationException("Problem deserializing xml");

var service = new OrderService();
await service.CreateOrdersAsync(result);