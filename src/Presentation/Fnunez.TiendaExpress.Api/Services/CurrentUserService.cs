using System.Security.Claims;
using Fnunez.TiendaExpress.Application.Common.Interfaces;

namespace Fnunez.TiendaExpress.Api.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? UserId => Guid.Empty.ToString();

    // public string? UserId => _httpContextAccessor.HttpContext?.User?
    //     .FindFirstValue(ClaimTypes.NameIdentifier);
}