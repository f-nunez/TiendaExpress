using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;

public class CustomerShippingAddress : BaseEntity
{
    public string CustomerId { get; private set; }
    public bool IsDefault { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Address { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }
    public string PhoneCountryCode { get; private set; }
    public string PhoneNumber { get; private set; }
    public string? PhoneExtension { get; private set; }

    public CustomerShippingAddress()
    {
        CustomerId = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Address = string.Empty;
        City = string.Empty;
        State = string.Empty;
        Country = string.Empty;
        ZipCode = string.Empty;
        PhoneCountryCode = string.Empty;
        PhoneNumber = string.Empty;
    }

    public CustomerShippingAddress(
        string id,
        string customerId,
        bool isDefault,
        string firstName,
        string lastName,
        string address,
        string city,
        string state,
        string country,
        string zipCode,
        string phoneCountryCode,
        string phoneNumber,
        string? phoneExtension)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(customerId, nameof(customerId));
        Guard.Against.NullOrEmpty(firstName, nameof(firstName));
        Guard.Against.NullOrEmpty(lastName, nameof(lastName));
        Guard.Against.NullOrEmpty(address, nameof(address));
        Guard.Against.NullOrEmpty(city, nameof(city));
        Guard.Against.NullOrEmpty(state, nameof(state));
        Guard.Against.NullOrEmpty(country, nameof(country));
        Guard.Against.NullOrEmpty(zipCode, nameof(zipCode));
        Guard.Against.NullOrEmpty(phoneCountryCode, nameof(phoneCountryCode));
        Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));

        Id = id;
        CustomerId = customerId;
        IsDefault = isDefault;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipCode;
        PhoneCountryCode = phoneCountryCode;
        PhoneNumber = phoneNumber;
        PhoneExtension = phoneExtension;
    }

    public void UpdateAddress(string address)
    {
        Guard.Against.NullOrEmpty(address, nameof(address));

        Address = address;
    }

    public void UpdateCity(string city)
    {
        Guard.Against.NullOrEmpty(city, nameof(city));

        City = city;
    }

    public void UpdateCountry(string country)
    {
        Guard.Against.NullOrEmpty(country, nameof(country));

        Country = country;
    }

    public void UpdateFirstName(string firstName)
    {
        Guard.Against.NullOrEmpty(firstName, nameof(firstName));

        FirstName = firstName;
    }

    public void UpdateIsDefault(bool isDefault)
    {
        IsDefault = isDefault;
    }

    public void UpdateLastName(string lastName)
    {
        Guard.Against.NullOrEmpty(lastName, nameof(lastName));

        LastName = lastName;
    }

    public void UpdatePhoneCountryCode(string phoneCountryCode)
    {
        Guard.Against.NullOrEmpty(phoneCountryCode, nameof(phoneCountryCode));

        PhoneCountryCode = phoneCountryCode;
    }

    public void UpdatePhoneExtension(string phoneExtension)
    {
        Guard.Against.NullOrEmpty(phoneExtension, nameof(phoneExtension));

        PhoneExtension = phoneExtension;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));

        PhoneNumber = phoneNumber;
    }

    public void UpdateState(string state)
    {
        Guard.Against.NullOrEmpty(state, nameof(state));

        State = state;
    }

    public void UpdateZipCode(string zipCode)
    {
        Guard.Against.NullOrEmpty(zipCode, nameof(zipCode));

        ZipCode = zipCode;
    }
}