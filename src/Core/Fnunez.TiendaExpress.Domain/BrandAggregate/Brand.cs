using Ardalis.GuardClauses;
using Fnunez.TiendaExpress.Domain.Common;

namespace Fnunez.TiendaExpress.Domain.BrandAggregate;

public class Brand : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string Code { get; private set; }

    public Brand()
    {
        Name = string.Empty;
        Code = string.Empty;
    }

    public Brand(string id, string name, string code)
    {
        Guard.Against.NullOrEmpty(id, nameof(id));
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(code, nameof(code));

        Id = id;
        Name = name;
        Code = code;
    }

    public void UpdateCode(string code)
    {
        Guard.Against.NullOrEmpty(code, nameof(code));

        Code = code;
    }

    public void UpdateName(string name)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));

        Name = name;
    }
}