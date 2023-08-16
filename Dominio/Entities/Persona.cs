using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Persona{
        
        [Key]
        public int PKCedula { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? TipoDocumentoFK { get; set; }
        public TipoDocumento ? TiposDeDocumentos { get; set; }
        public string ? GeneroFK { get; set; }
        public Genero ? Generos { get; set; }
        public string ? CiudadFK { get; set; }
        public Ciudad ? Ciudades { get; set; }
        public string ? TipoPersonaFK { get; set; }
        public TipoPersona ? TipoDePersonas { get; set; }
        public ICollection<Direccion> ? Direcciones { get; set; }
        public ICollection<Matricula> ? Matriculas { get; set; }
        public ICollection<TrainerSalon> ? TrainersDeSalones { get; set; }
    }
