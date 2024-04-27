using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.CategoryAggregate;

public class Category : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Code { get; private set; }

    public Category()
    {
        Name = string.Empty;
        Description = string.Empty;
        Code = string.Empty;
    }

    public Category(
        string id,
        string name,
        string description,
        string code)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(description, nameof(description));
        Guard.Against.NullOrEmpty(code, nameof(code));

        Id = id;
        Name = name;
        Description = description;
        Code = code;
    }

    public void UpdateCode(string code)
    {
        Guard.Against.NullOrEmpty(code, nameof(code));

        Code = code;
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
}