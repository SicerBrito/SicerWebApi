using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Ciudad{

        [Key]
        public int IdCiudad { get; set; }
        public string ? NombreCiudad { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento ? Departamentos { get; set; }
        public ICollection<Persona> ? Personas { get; set; }

    }