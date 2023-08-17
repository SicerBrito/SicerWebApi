using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ITipoDocumento
    {
        Task<TipoDocumento> ? GetByIdAsync(string Id);
        Task<IEnumerable<TipoDocumento>> GetAllAsync();
        IEnumerable<TipoDocumento> Find(Expression<Func<TipoDocumento, bool>> expression);
        void Add(TipoDocumento entity);
        void AddRange(IEnumerable<TipoDocumento> entities);
        void Remove(TipoDocumento entity);
        void RemoveRange(IEnumerable<TipoDocumento> entities);
        void Update(TipoDocumento entity);
    }
