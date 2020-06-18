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
    public class CompraController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CompraController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Compra>>> Get()
        {
            return await _db.Compras.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Compra compra)
        {
            _db.Add(compra);
            await _db.SaveChangesAsync();
            return Ok(compra.ID);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var compra = await _db.Compras.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(compra);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}