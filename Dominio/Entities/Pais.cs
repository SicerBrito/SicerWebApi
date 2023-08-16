using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Pais{
        
        [Key]
        public string ? PKNombrePais { get; set; }
        public ICollection<Departamento> ? Departamentos { get; set;}
    
    }
