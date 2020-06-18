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
    public class FuncionarioController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public FuncionarioController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Funcionario>>> Get()
        {
            return await _db.Funcionarios.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Funcionario funcionario)
        {
            _db.Add(funcionario);
            await _db.SaveChangesAsync();
            return Ok(funcionario.ID);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var funcionario = await _db.Funcionarios.FirstOrDefaultAsync(x => x.ID == id);
            _db.Remove(funcionario);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}