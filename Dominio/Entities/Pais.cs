using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Pais{
        
        [Key]
        public int IdPais { get; set; }
        public string ? NombrePais { get; set; }
        public ICollection<Departamento> ? Departamentos { get; set;}
    
    }
