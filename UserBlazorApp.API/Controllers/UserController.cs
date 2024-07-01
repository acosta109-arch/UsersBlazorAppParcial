using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersBlazorApp.API.Context;
using UsersBlazorApp.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserBlazorApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(UsersDbContext Context) : ControllerBase
{


    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        /*        var claims = await Context.AspNetUsers
                    .Where(x => x.Id == id)
                    .Select(u =>
                             u.Role.SelectMany(r => r.AspNetRoleClaims
                                .Select(c => new ClaimDto(c.ClaimType))
                            )
                    )
                    .ToListAsync();*/


        var query = from user in Context.AspNetUsers
                where user.Id == id
                from r in user.Role
                from c in r.AspNetRoleClaims
                select new ClaimDto(c.ClaimType);

        var claims = await query.ToListAsync();

        return Ok(claims);
    }


}


public record UserDto1(int UsuarioId, List<ClaimDto> Claims) { }

public class UserDto
{
    public int UsuarioId { get; set; }
    public List<ClaimDto> Claims { get; set; } = [];
}

public record ClaimDto(string? Name) { }