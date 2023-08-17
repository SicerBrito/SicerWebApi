using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IDireccion
    {
        Task<Direccion> ? GetByIdAsync(string Id);
        Task<IEnumerable<Direccion>> GetAllAsync();
        IEnumerable<Direccion> Find(Expression<Func<Direccion, bool>> expression);
        void Add(Direccion entity);
        void AddRange(IEnumerable<Direccion> entities);
        void Remove(Direccion entity);
        void RemoveRange(IEnumerable<Direccion> entities);
        void Update(Direccion entity);
    }
