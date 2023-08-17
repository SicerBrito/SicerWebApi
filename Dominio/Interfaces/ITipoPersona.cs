using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ITipoPersona
    {
        Task<TipoPersona> ? GetByIdAsync(string Id);
        Task<IEnumerable<TipoPersona>> GetAllAsync();
        IEnumerable<TipoPersona> Find(Expression<Func<TipoPersona, bool>> expression);
        void Add(TipoPersona entity);
        void AddRange(IEnumerable<TipoPersona> entities);
        void Remove(TipoPersona entity);
        void RemoveRange(IEnumerable<TipoPersona> entities);
        void Update(TipoPersona entity);
    }
