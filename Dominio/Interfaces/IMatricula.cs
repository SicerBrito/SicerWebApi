using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IMatricula
    {
        Task<Matricula> ? GetByIdAsync(string Id);
        Task<IEnumerable<Matricula>> GetAllAsync();
        IEnumerable<Matricula> Find(Expression<Func<Matricula, bool>> expression);
        void Add(Matricula entity);
        void AddRange(IEnumerable<Matricula> entities);
        void Remove(Matricula entity);
        void RemoveRange(IEnumerable<Matricula> entities);
        void Update(Matricula entity);
    }
