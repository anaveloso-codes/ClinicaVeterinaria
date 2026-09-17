namespace ClinicaVeterinaria.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Veterinario> Veterinarios { get; set; } 

    }
}
