using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.BasketAggregate.Entities;

public class BasketItem : BaseEntity
{
    public string BasketId { get; private set; }
    public string ProductId { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public BasketItem()
    {
        BasketId = string.Empty;
        ProductId = string.Empty;
    }

    public BasketItem(
        string id,
        string basketId,
        string productId,
        decimal price,
        int quantity)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(basketId, nameof(basketId));
        Guard.Against.NullOrEmpty(productId, nameof(productId));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));

        Id = id;
        BasketId = basketId;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public void UpdatePrice(decimal price)
    {
        Guard.Against.NegativeOrZero(price, nameof(price));

        Price = price;
    }

    public void UpdateQuantity(int quantity)
    {
        Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);

        Quantity = quantity;
    }
}