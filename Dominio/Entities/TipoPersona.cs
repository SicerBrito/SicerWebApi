using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class TipoPersona{
        
        [Key]
        public string ? PKTipoPersona { get; set; }
        public string ? Descripcion { get; set; }
        public ICollection<Persona> ? Personas { get; set; }
        
    }
