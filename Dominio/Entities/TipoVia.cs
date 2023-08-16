using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class TipoVia{
        
        [Key]
        public string ? PKNombreTipoVia { get; set; }
        public string ? Abreviatura { get; set; }
        public ICollection<Direccion> ? Direcciones { get; set; }
        
    }
