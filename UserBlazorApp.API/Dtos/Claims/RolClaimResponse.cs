using UserBlazorApp.API.Dtos.Roles;
using UsersBlazorApp.Data.Models;

namespace UserBlazorApp.API.Dtos.Claims;

public class RolClaimResponse
{
	public int Id { get; set; }

	public int RoleId { get; set; }

	public string? ClaimType { get; set; }

	public string? ClaimValue { get; set; }
}
