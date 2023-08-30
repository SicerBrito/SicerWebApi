using System.Security.Claims;
using Aplicacion.Contratos;
using Dominio.Entities;

namespace Seguridad.TokenSeguridad;
public class JwtGenerador : IJwtGenerator
{
    public string CrearTopken(Pais pais)
    {
        var claims = new List<Claim>{
            
        };
    }
}

