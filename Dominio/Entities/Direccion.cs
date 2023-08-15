using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Direccion{
        
        [Key]
        public int IdDireccion { get; set; }
        public string ? TipoViaId { get; set; }
        public int NumeroDireccion { get; set; }
        public string ? Letra { get; set; }
        public string ? SufijoCardinal { get; set; }
        public int NumeroViaSecundaria { get; set; }
        public string? LetraViaSecundaria { get; set; }
        public string? SufijoCardinalViaSecundaria { get; set; }
        public int PersonaId { get; set; }
        public Persona ? Personas { get; set; }

    }
