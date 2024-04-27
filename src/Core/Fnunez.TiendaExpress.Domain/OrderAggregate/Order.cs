using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;
using Fnunez.TiendaExpress.Domain.OrderAggregate.Entities;
using Fnunez.TiendaExpress.Domain.OrderAggregate.Enums;
using Fnunez.TiendaExpress.Domain.OrderAggregate.ValueObjects;

namespace Fnunez.TiendaExpress.Domain.OrderAggregate;

public class Order : BaseEntity, IAggregateRoot
{
    public string CustomerId { get; private set; }
    public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.UtcNow;
    public OrderStatus OrderStatus { get; private set; } = OrderStatus.Pending;
    public decimal SubTotal { get; private set; }
    public decimal DeliveryFee { get; private set; }
    public string PaymentIntentId { get; private set; }
    public ShippingAddress ShippingAddress { get; private set; } = null!;

    private readonly List<OrderItem> _orderItems = [];
    public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    public Order()
    {
        CustomerId = string.Empty;
        PaymentIntentId = string.Empty;
    }

    public Order(
        string id,
        string customerId,
        DateTimeOffset orderDate,
        OrderStatus orderStatus,
        decimal subTotal,
        decimal deliveryFee,
        string paymentIntentId,
        ShippingAddress shippingAddress)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(customerId, nameof(customerId));
        Guard.Against.NullOrOutOfRange(orderDate, nameof(orderDate), DateTimeOffset.MinValue, DateTimeOffset.MaxValue);
        Guard.Against.NegativeOrZero(subTotal, nameof(subTotal));
        Guard.Against.NegativeOrZero(deliveryFee, nameof(deliveryFee));
        Guard.Against.NullOrEmpty(paymentIntentId, nameof(paymentIntentId));
        Guard.Against.Null(shippingAddress, nameof(shippingAddress));

        Id = id;
        CustomerId = customerId;
        OrderDate = orderDate;
        OrderStatus = orderStatus;
        SubTotal = subTotal;
        DeliveryFee = deliveryFee;
        PaymentIntentId = paymentIntentId;
        ShippingAddress = shippingAddress;
    }

    public void AddOrderItem(OrderItem orderItem)
    {
        Guard.Against.Null(orderItem, nameof(orderItem));

        _orderItems.Add(orderItem);
    }

    public decimal GetSubTotal()
    {
        var subTotal = 0m;

        foreach (var item in _orderItems)
            subTotal += item.Price * item.Quantity;

        return subTotal;
    }

    public decimal GetTotal()
    {
        return SubTotal + DeliveryFee;
    }

    public void RemoveOrderItem(OrderItem orderItem)
    {
        Guard.Against.Null(orderItem, nameof(orderItem));

        OrderItem? existingOrderItem = _orderItems
            .FirstOrDefault(oi => oi.Id == orderItem.Id);

        Guard.Against.Null(existingOrderItem);

        existingOrderItem.IsActive = false;
    }

    public void UpdateDeliveryFee(decimal deliveryFee)
    {
        Guard.Against.NegativeOrZero(deliveryFee);

        DeliveryFee = deliveryFee;
    }

    public void UpdateOrderStatus(OrderStatus orderStatus)
    {
        OrderStatus = orderStatus;
    }

    public void UpdateShippingAddress(ShippingAddress shippingAddress)
    {
        Guard.Against.Null(shippingAddress, nameof(shippingAddress));

        ShippingAddress = shippingAddress;
    }

    public void UpdateSubTotal(decimal subTotal)
    {
        Guard.Against.NegativeOrZero(subTotal);

        SubTotal = subTotal;
    }
}