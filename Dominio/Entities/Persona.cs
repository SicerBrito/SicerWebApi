using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Persona{
        
        [Key]
        public int IdPersona { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public int GeneroId { get; set; }
        public Genero ? Generos { get; set; }
        public int CiudadId { get; set; }
        public Ciudad ? Ciudades { get; set; }
        public int TipoPersonaId { get; set; }
        public TipoPersona ? TipoDePersonas { get; set; }
        public ICollection<Direccion> ? Direcciones { get; set; }
        public ICollection<Matricula> ? Matriculas { get; set; }
        public ICollection<TrainerSalon> ? TrainersDeSalones { get; set; }
    }
