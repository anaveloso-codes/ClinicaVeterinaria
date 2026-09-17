using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace ClinicaVeterinaria.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
    }
}

