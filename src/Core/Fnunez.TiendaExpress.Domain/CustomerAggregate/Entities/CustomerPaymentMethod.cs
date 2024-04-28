using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;

public class CustomerPaymentMethod : BaseEntity
{
    public string CustomerId { get; private set; }
    public string Alias { get; private set; }
    public string CardId { get; private set; }
    public string LastCardNumbers { get; private set; }

    public CustomerPaymentMethod()
    {
        CustomerId = string.Empty;
        Alias = string.Empty;
        CardId = string.Empty;
        LastCardNumbers = string.Empty;
    }

    public CustomerPaymentMethod(
        string id,
        string customerId,
        string alias,
        string cardId,
        string lastCardNumbers)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(customerId, nameof(customerId));
        Guard.Against.NullOrEmpty(alias, nameof(alias));
        Guard.Against.NullOrEmpty(cardId, nameof(cardId));
        Guard.Against.NullOrEmpty(lastCardNumbers, nameof(lastCardNumbers));

        Id = id;
        CustomerId = customerId;
        Alias = alias;
        CardId = cardId;
        LastCardNumbers = lastCardNumbers;
    }

    public void UpdateAlias(string alias)
    {
        Guard.Against.NullOrEmpty(alias, nameof(alias));

        Alias = alias;
    }

    public void UpdateCardId(string cardId)
    {
        Guard.Against.NullOrEmpty(cardId, nameof(cardId));

        CardId = cardId;
    }

    public void UpdateLastCardNumbers(string lastCardNumbers)
    {
        Guard.Against.NullOrEmpty(lastCardNumbers, nameof(lastCardNumbers));

        LastCardNumbers = lastCardNumbers;
    }
}