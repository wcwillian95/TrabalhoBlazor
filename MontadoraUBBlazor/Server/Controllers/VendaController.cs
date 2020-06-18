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
    public class VendaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public VendaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Venda>>> Get()
        {
            return await _db.Vendas.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Venda venda)
        {
            _db.Add(venda);
            await _db.SaveChangesAsync();
            return Ok(venda.ID);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var venda = await _db.Vendas.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(venda);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}