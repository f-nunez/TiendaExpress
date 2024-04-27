using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;
using Fnunez.TiendaExpress.Domain.OrderAggregate.ValueObjects;

namespace Fnunez.TiendaExpress.Domain.OrderAggregate.Entities;

public class OrderItem : BaseEntity
{
    public string OrderId { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    public ProductItemOrdered ItemOrdered { get; private set; } = null!;

    public OrderItem()
    {
        OrderId = string.Empty;
    }

    public OrderItem(
        string id,
        string orderId,
        decimal price,
        int quantity,
        ProductItemOrdered itemOrdered)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(orderId, nameof(orderId));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));
        Guard.Against.Null(itemOrdered, nameof(itemOrdered));

        Id = id;
        OrderId = orderId;
        Price = price;
        Quantity = quantity;
        ItemOrdered = itemOrdered;
    }

    public void UpdateItemOrdered(ProductItemOrdered itemOrdered)
    {
        Guard.Against.Null(itemOrdered, nameof(itemOrdered));

        ItemOrdered = itemOrdered;
    }

    public void UpdatePrice(decimal price)
    {
        Guard.Against.NegativeOrZero(price, nameof(price));

        Price = price;
    }

    public void UpdateQuantity(int quantity)
    {
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));

        Quantity = quantity;
    }
}