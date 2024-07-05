using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UsersBlazorApp.Data.Models;

public partial class AspNetRoleClaims
{
	[Key]
	public int Id { get; set; }

	public int RoleId { get; set; }

	public string? ClaimType { get; set; }

	public string? ClaimValue { get; set; }

	[ForeignKey("RoleId")]
	[InverseProperty("AspNetRoleClaims")]
	public virtual AspNetRoles Role { get; set; } = null!;
}
