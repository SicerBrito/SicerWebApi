using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ICiudad
    {
        Task<Ciudad> ? GetByIdAsync(string Id);
        Task<IEnumerable<Ciudad>> GetAllAsync();
        IEnumerable<Ciudad> Find(Expression<Func<Ciudad, bool>> expression);
        void Add(Ciudad entity);
        void AddRange(IEnumerable<Ciudad> entities);
        void Remove(Ciudad entity);
        void RemoveRange(IEnumerable<Ciudad> entities);
        void Update(Ciudad entity);
    }
