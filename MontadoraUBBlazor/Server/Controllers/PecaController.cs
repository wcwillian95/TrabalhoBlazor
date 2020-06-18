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
    public class PecaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PecaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Peca>>> Get()
        {
            return await _db.Pecas.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Peca peca)
        {
            _db.Add(peca);
            await _db.SaveChangesAsync();
            return Ok(peca.ID);
        }
        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var peca = await _db.Pecas.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(peca);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}