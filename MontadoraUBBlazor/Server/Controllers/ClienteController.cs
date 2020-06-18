using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontadoraUBBlazor.Server.Data;
using MontadoraUBBlazor.Shared.Models;

namespace MontadoraUBBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await _db.Clientes.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            _db.Add(cliente);
            await _db.SaveChangesAsync();
            return Ok(cliente.ID);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete (int id)
        {
            var cliente = await _db.Clientes.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(cliente);
            await _db.SaveChangesAsync();

            return NoContent();
        }
            

    }
}