using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Direccion{
        
        [Key]
        public string ? PKDireccion { get; set; }
        public string ? TipoViaFK { get; set; }
        public TipoVia ? TipoDeVias { get; set; }
        public int NroDireccion { get; set; }
        public string ? Letra { get; set; }
        public string ? SufijoCardinal { get; set; }
        public int NroViaSecundaria { get; set; }
        public string? LetraVS { get; set; }
        public string? SufijoCardinalVS { get; set; }
        public int PersonaFK { get; set; }
        public Persona ? Personas { get; set; }

    }
