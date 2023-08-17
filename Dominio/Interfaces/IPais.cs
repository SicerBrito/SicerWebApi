using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IPais
    {
        Task<Pais> ? GetByIdAsync(string Id);
        Task<IEnumerable<Pais>> GetAllAsync();
        IEnumerable<Pais> Find(Expression<Func<Pais, bool>> expression);
        void Add(Pais entity);
        void AddRange(IEnumerable<Pais> entities);
        void Remove(Pais entity);
        void RemoveRange(IEnumerable<Pais> entities);
        void Update(Pais entity);
    }
