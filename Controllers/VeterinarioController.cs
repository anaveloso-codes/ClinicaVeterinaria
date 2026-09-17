using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeterinarioController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CriarVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Professor salvo com sucesso!!");
        }

    }
}

