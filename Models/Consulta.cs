namespace ClinicaVeterinaria.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHora { get; set; }
        public int PetId { get; set; }
        public int VetrinarioId { get; set; }
    }
}
