using AutoMapper;
using XmlToDatabase.Data;
using XmlToDatabase.Data.Models;

namespace XmlToDatabase.Services;

public class OrderService : IOrderService
{
    public async Task CreateOrdersAsync (XmlInput input)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<OrderDto, Order>();
            cfg.CreateMap<ProductDto, Product>();
            cfg.CreateMap<UserDto, User>();
        });
        

        var mapper = new Mapper(config).DefaultContext.Mapper;
        await using var context = new DataContext();

        foreach (var orderItem in input.OrdersArray)
        {
            var user = mapper.Map<User>(orderItem.UserDto);
    
            var order = mapper.Map<Order>(orderItem);
            order.User = user;

            context.Users.Add(user);
            context.Orders.Add(order);
    
            foreach (var productItem in orderItem.Products)
            {
                var orderProduct = new OrderProduct
                {
                    Order = order,
                    Product = mapper.Map<Product>(productItem)
                };
                context.OrderProducts.Add(orderProduct);
            }
        }
        await context.SaveChangesAsync();
    }
}