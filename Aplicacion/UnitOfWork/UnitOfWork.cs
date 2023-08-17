using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SicerWebApiContext _context;
        
    }
