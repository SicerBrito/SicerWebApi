using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ITipoVia
    {
        Task<TipoVia> ? GetByIdAsync(string Id);
        Task<IEnumerable<TipoVia>> GetAllAsync();
        IEnumerable<TipoVia> Find(Expression<Func<TipoVia, bool>> expression);
        void Add(TipoVia entity);
        void AddRange(IEnumerable<TipoVia> entities);
        void Remove(TipoVia entity);
        void RemoveRange(IEnumerable<TipoVia> entities);
        void Update(TipoVia entity);
    }
