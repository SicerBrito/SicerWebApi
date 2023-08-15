using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Departamento{
        
        [Key]
        public int IdDepartamento { get; set; }
        public string ? NombreDepartamento { get; set; }
        public int PaisId { get; set; }
        public Pais ? Paises { get; set; }
        public ICollection<Ciudad> ? Ciudades { get; set; }
        
    }
