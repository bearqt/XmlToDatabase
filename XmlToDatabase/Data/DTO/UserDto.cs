using System.Xml.Serialization;

namespace XmlToDatabase.Data.Models;

[XmlType("user")]
public class UserDto
{
    public UserDto()
    {
        
    }

    public int Id { get; set; }
    [XmlElement("fio")]
    public string Fio { get; set; }
    [XmlElement("email")]
    public string Email { get; set; }
}