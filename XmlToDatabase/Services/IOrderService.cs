using XmlToDatabase.Data.Models;

namespace XmlToDatabase.Services;

public interface IOrderService
{
    Task CreateOrdersAsync(XmlInput input);
}