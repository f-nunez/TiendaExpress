using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.OrderAggregate.ValueObjects;

public class ProductItemOrdered : ValueObject
{
    public string ProductId { get; private set; }
    public string Name { get; private set; }
    public string PictureUri { get; private set; }

    public ProductItemOrdered()
    {
        ProductId = string.Empty;
        Name = string.Empty;
        PictureUri = string.Empty;
    }

    public ProductItemOrdered(
        string productId,
        string name,
        string pictureUri)
    {
        Guard.Against.NullOrEmpty(productId, nameof(productId));
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));

        ProductId = productId;
        Name = name;
        PictureUri = pictureUri;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ProductId;
        yield return Name;
        yield return PictureUri;
    }
}