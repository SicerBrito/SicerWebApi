using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Ciudad{

        [Key]
        public string ? PKNombreCiudad { get; set; }
        public string ? DepartamentoFK { get; set; }
        public Departamento ? Departamentos { get; set; }
        public ICollection<Persona> ? Personas { get; set; }

    }