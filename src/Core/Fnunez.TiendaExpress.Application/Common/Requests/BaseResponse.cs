namespace Fnunez.TiendaExpress.Application.Common.Requests;

public abstract class BaseResponse : BaseMessage
{
    public BaseResponse(Guid correlationId)
    {
        _correlationId = correlationId;
    }
}