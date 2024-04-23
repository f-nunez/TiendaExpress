using System.Text.Json;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Fnunez.TiendaExpress.Application.Common.Behaviors;

public class UnhandledExceptionBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse> where TRequest
    : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;

    public UnhandledExceptionBehavior(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            string requestName = typeof(TRequest).Name;
            string serializedRequest = JsonSerializer.Serialize(request);

            _logger.LogError(
                ex,
                "Users Unhandled Exception for Request: {Name} {@Request}",
                requestName,
                serializedRequest
            );

            throw;
        }
    }
}