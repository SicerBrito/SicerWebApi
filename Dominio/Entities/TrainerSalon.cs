using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class TrainerSalon{
        
        [Key]
        public int PersonaId { get; set; }
        public Persona ? Personas { get; set; }
        public int SalonId { get; set; }
        public Salon ? Salones { get; set; }
        
    }
