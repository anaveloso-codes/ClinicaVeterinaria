using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            return await _context.Pets.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CriarPet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return Ok("Pet salvo com sucesso!!");
        }
    }
}
