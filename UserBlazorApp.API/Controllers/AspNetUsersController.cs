using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersBlazorApp.API.Context;
using UsersBlazorApp.Data.Interfaces;
using UsersBlazorApp.Data.Models;

namespace UserBlazorApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AspNetUsersController(IApiService<AspNetUsers> userService) : ControllerBase
{
    // GET: api/AspNetUsers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetAspNetUsers()
    {
        return await userService.GetAllAsync();
    }

    // GET: api/AspNetUsers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<AspNetUsers>> GetAspNetUsers(int id)
    {
        var obtener = await userService.GetByIdAsync(id);

        if (obtener is null)
        {
            return NotFound();
        }

        return obtener;
    }

	// POST: api/AspNetUsers
	[HttpPost]
	public async Task<ActionResult<AspNetUsers>> PostAspNetUsers(AspNetUsers user) {

        var resultado = await userService.AddAsync(user);

        if(resultado != null)
		    return Ok(resultado);
		
		
        return NotFound();

		//_context.AspNetUsers.Add(aspNetUsers);
		//await _context.SaveChangesAsync();

		//return CreatedAtAction("GetAspNetUsers", new { id = aspNetUsers.Id }, aspNetUsers);
	}

	// PUT: api/AspNetUsers/5
	[HttpPut("{id}")]
    public async Task<IActionResult> PutAspNetUsers(int id, AspNetUsers user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

		var modificado = await userService.UpdateAsync(user);
		if (!modificado)
			return NotFound($"No se pudo actualizar el artículo con ID {id}. Puede que el artículo no exista.");

		return NoContent();
    }

   

    // DELETE: api/AspNetUsers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAspNetUsers(int id)
    {
        var eliminado = await userService.DeleteAsync(id);
        if (!eliminado)
            return NotFound();

        return NoContent();
    }
}
