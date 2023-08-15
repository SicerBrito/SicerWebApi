using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Genero{

        [Key]
        public int IdGenero { get; set; }
        public string ? NombreGenero { get; set; }
        public ICollection<Persona> ? Personas { get; set; }
        
    }
