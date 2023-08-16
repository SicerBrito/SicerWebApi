using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class TrainerSalon{
        
        [Key]
        public int PersonaFK { get; set; }
        public Persona ? Personas { get; set; }
        public int SalonFK { get; set; }
        public Salon ? Salones { get; set; }
        
    }
