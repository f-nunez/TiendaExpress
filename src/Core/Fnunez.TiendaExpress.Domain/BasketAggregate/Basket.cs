using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.BasketAggregate.Entities;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.BasketAggregate;

public class Basket : BaseEntity, IAggregateRoot
{
    public string CustomerId { get; private set; }
    public string PaymentIntentId { get; private set; }
    public string ClientSecret { get; private set; }
    private readonly List<BasketItem> _items = [];
    public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();
    public int TotalItems => _items.Sum(i => i.Quantity);

    public Basket()
    {
        CustomerId = string.Empty;
        PaymentIntentId = string.Empty;
        ClientSecret = string.Empty;
    }

    public Basket(
        string id,
        string customerId,
        string paymentIntentId,
        string clientSecret)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(customerId, nameof(customerId));
        Guard.Against.NullOrEmpty(paymentIntentId, nameof(paymentIntentId));
        Guard.Against.NullOrEmpty(clientSecret, nameof(clientSecret));

        Id = id;
        CustomerId = customerId;
        PaymentIntentId = paymentIntentId;
        ClientSecret = clientSecret;
    }

    public void AddItem(
        string productId,
        decimal price,
        int quantity)
    {
        Guard.Against.NullOrEmpty(productId, nameof(productId));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));

        if (!Items.Any(i => i.ProductId == productId))
        {
            var newItem = new BasketItem(
                Guid.NewGuid().ToString(),
                Id!,
                productId,
                price,
                quantity
            );

            _items.Add(newItem);

            return;
        }

        var existingItem = Items.First(i => i.ProductId == productId);
        existingItem.UpdateQuantity(quantity);
    }

    public void AddItem(BasketItem item)
    {
        Guard.Against.Null(item, nameof(item));

        _items.Add(item);
    }

    public void RemoveItem(BasketItem item)
    {
        Guard.Against.Null(item, nameof(item));

        BasketItem? existingItem = _items.FirstOrDefault(i => i.Id == item.Id);

        Guard.Against.Null(existingItem, nameof(existingItem));

        existingItem.IsActive = false;
    }
}