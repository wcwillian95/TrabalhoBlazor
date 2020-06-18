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
    public class FornecedorController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public FornecedorController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Fornecedor>>> Get()
        {
            return await _db.Fornecedores.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Fornecedor fornecedor)
        {
            _db.Add(fornecedor);
            await _db.SaveChangesAsync();
            return Ok(fornecedor.ID);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var fornecedor = await _db.Fornecedores.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(fornecedor);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}