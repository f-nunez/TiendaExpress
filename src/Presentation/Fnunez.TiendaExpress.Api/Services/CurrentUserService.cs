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

    public string? UserId => "1b9de6c3-521d-457d-a83e-8110f48533ea";

    // public string? UserId => _httpContextAccessor.HttpContext?.User?
    //     .FindFirstValue(ClaimTypes.NameIdentifier);
}