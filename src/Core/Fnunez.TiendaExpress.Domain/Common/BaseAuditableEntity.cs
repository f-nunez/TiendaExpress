namespace Fnunez.TiendaExpress.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public string? CreatedBy { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTimeOffset? UpdatedOn { get; set; }
}