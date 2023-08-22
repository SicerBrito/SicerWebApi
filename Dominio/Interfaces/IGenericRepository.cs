using System.Linq.Expressions;

namespace Dominio.Interfaces;
    public interface IGenericRepository<T> where T : class{
        
        Task<T> ? GetByIdAsync(string Id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        
    }
