namespace UserBlazorApp.API.Dtos.Roles;
using UserBlazorApp.API.Dtos.Claims;

public class RolRequest
{
	public string? Name { get; set; }

	public ICollection<RolClaimRequest> AspNetRoleClaims { get; set; } = new List<RolClaimRequest>();
}
