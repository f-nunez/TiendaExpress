using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.BrandAggregate;
using Fnunez.TiendaExpress.Domain.CategoryAggregate;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.ProductAggregate;

public class Product : BaseEntity, IAggregateRoot
{
    public string BrandId { get; private set; }
    public string CategoryId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string SKU { get; private set; }
    public decimal Price { get; private set; }
    public string PictureUri { get; private set; }
    public int QuantityInStock { get; private set; }

    public Brand Brand { get; private set; } = null!;
    public Category Category { get; private set; } = null!;

    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
        SKU = string.Empty;
        PictureUri = string.Empty;
        CategoryId = string.Empty;
        BrandId = string.Empty;
    }

    public Product(
        string id,
        string brandId,
        string categoryId,
        string name,
        string description,
        string sku,
        decimal price,
        string pictureUri,
        int quantityInStock)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(brandId, nameof(brandId));
        Guard.Against.NullOrEmpty(categoryId, nameof(categoryId));
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(description, nameof(description));
        Guard.Against.NullOrEmpty(sku, nameof(sku));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));
        Guard.Against.Negative(quantityInStock, nameof(quantityInStock));

        Id = id;
        BrandId = brandId;
        CategoryId = categoryId;
        Name = name;
        Description = description;
        SKU = sku;
        Price = price;
        PictureUri = pictureUri;
        QuantityInStock = quantityInStock;
    }

    public void UpdateBrandId(string brandId)
    {
        Guard.Against.NullOrEmpty(brandId, nameof(brandId));

        BrandId = brandId;
    }

    public void UpdateCategoryId(string categoryId)
    {
        Guard.Against.NullOrEmpty(categoryId, nameof(categoryId));

        CategoryId = categoryId;
    }

    public void UpdateDescription(string description)
    {
        Guard.Against.NullOrEmpty(description, nameof(description));

        Description = description;
    }

    public void UpdateName(string name)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));

        Name = name;
    }

    public void UpdatePictureUri(string pictureUri)
    {
        Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));

        PictureUri = pictureUri;
    }

    public void UpdatePrice(decimal price)
    {
        Guard.Against.NegativeOrZero(price, nameof(price));

        Price = price;
    }

    public void UpdateQuantityInStock(int quantityInStock)
    {
        Guard.Against.NegativeOrZero(quantityInStock, nameof(quantityInStock));

        QuantityInStock = quantityInStock;
    }

    public void UpdateSKU(string sku)
    {
        Guard.Against.NullOrEmpty(sku, nameof(sku));

        SKU = sku;
    }
}