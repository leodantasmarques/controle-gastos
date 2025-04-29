using Microsoft.AspNetCore.Mvc;
using ControleGastos.Data;
using ControleGastos.Models;

namespace ControleGastos.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class DespesasController : ControllerBase{
        private readonly AppDbContext _context;

        public DespesasController(AppDbContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDespesas(){
            return Ok(_context.Despesas.ToList());
        }

        [HttpPost]
        public IActionResult AddDespesa(Despesa despesa){
            _context.Despesas.Add(despesa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetDespesas), despesa);
        }
    }
}