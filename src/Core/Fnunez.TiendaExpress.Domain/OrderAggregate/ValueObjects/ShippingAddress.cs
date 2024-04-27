using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.OrderAggregate.ValueObjects;

public class ShippingAddress : ValueObject
{
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

    public ShippingAddress()
    {
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

    public ShippingAddress(
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
        Guard.Against.NullOrEmpty(firstName, nameof(firstName));
        Guard.Against.NullOrEmpty(lastName, nameof(lastName));
        Guard.Against.NullOrEmpty(address, nameof(address));
        Guard.Against.NullOrEmpty(city, nameof(city));
        Guard.Against.NullOrEmpty(state, nameof(state));
        Guard.Against.NullOrEmpty(country, nameof(country));
        Guard.Against.NullOrEmpty(zipCode, nameof(zipCode));
        Guard.Against.NullOrEmpty(phoneCountryCode, nameof(phoneCountryCode));
        Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));

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

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return LastName;
        yield return Address;
        yield return City;
        yield return State;
        yield return Country;
        yield return ZipCode;
        yield return PhoneCountryCode;
        yield return PhoneNumber;
        yield return PhoneExtension!;
    }
}