using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;
using Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;

namespace Fnunez.TiendaExpress.Domain.CustomerAggregate;

public class Customer : BaseEntity, IAggregateRoot
{
    public string IdentityId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    private readonly List<CustomerPaymentMethod> _paymentMethods = [];
    public IReadOnlyCollection<CustomerPaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();
    private readonly List<CustomerShippingAddress> _shippingAddresses = [];
    public IReadOnlyCollection<CustomerShippingAddress> ShippingAddresses => _shippingAddresses.AsReadOnly();

    public Customer()
    {
        IdentityId = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
    }

    public Customer(
        string id,
        string identityId,
        string firstName,
        string lastName,
        string email)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(identityId, nameof(identityId));
        Guard.Against.NullOrEmpty(firstName, nameof(firstName));
        Guard.Against.NullOrEmpty(lastName, nameof(lastName));
        Guard.Against.NullOrEmpty(email, nameof(email));

        Id = id;
        IdentityId = identityId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void AddPaymentMethod(CustomerPaymentMethod paymentMethod)
    {
        Guard.Against.Null(paymentMethod, nameof(paymentMethod));

        _paymentMethods.Add(paymentMethod);
    }

    public void AddShippingAddress(CustomerShippingAddress shippingAddress)
    {
        Guard.Against.Null(shippingAddress, nameof(shippingAddress));

        _shippingAddresses.Add(shippingAddress);
    }

    public void RemovePaymentMethod(CustomerPaymentMethod paymentMethod)
    {
        Guard.Against.Null(paymentMethod);

        CustomerPaymentMethod? existingPaymentMethod = _paymentMethods
            .FirstOrDefault(pm => pm.Id == paymentMethod.Id);

        Guard.Against.Null(existingPaymentMethod, nameof(existingPaymentMethod));

        existingPaymentMethod.IsActive = false;
    }

    public void RemoveShippingAddress(CustomerShippingAddress shippingAddress)
    {
        Guard.Against.Null(shippingAddress);

        CustomerShippingAddress? existingShippingAddress = _shippingAddresses
            .FirstOrDefault(sa => sa.Id == shippingAddress.Id);

        Guard.Against.Null(existingShippingAddress, nameof(existingShippingAddress));

        existingShippingAddress.IsActive = false;
    }

    public void UpdateFirstName(string firstName)
    {
        Guard.Against.NullOrEmpty(firstName, nameof(firstName));

        FirstName = firstName;
    }

    public void UpdateLastName(string lastName)
    {
        Guard.Against.NullOrEmpty(lastName, nameof(lastName));

        LastName = lastName;
    }

    public void UpdateEmail(string email)
    {
        Guard.Against.NullOrEmpty(email, nameof(email));

        Email = email;
    }
}