using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Salon{
        
        [Key]
        public string ? PKNombreSalon { get; set; }
        public int Capacidad { get; set; }
        public ICollection<Matricula> ? Matriculas { get; set; }
        public ICollection<TrainerSalon> ?  TrainersDeSalones { get; set; }

    }
