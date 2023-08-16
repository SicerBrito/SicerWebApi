using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Genero{

        [Key]
        public string ? PKNombreGenero { get; set; }
        public ICollection<Persona> ? Personas { get; set; }
        
    }
