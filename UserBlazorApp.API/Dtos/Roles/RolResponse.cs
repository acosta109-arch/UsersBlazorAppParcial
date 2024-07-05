using UserBlazorApp.API.Dtos.Claims;

namespace UserBlazorApp.API.Dtos.Roles;

public class RolResponse
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public List<RolClaimResponse> RoleClaims { get; set; } = new List<RolClaimResponse>();
}
