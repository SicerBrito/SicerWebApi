using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Departamento{
        
        [Key]
        public string ? PKNombreDepartamento { get; set; }
        public string ? PaisFK { get; set; }
        public Pais ? Paises { get; set; }
        public ICollection<Ciudad> ? Ciudades { get; set; }
        
    }
