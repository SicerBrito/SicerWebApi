using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IGenero
    {
        Task<Genero> ? GetByIdAsync(string Id);
        Task<IEnumerable<Genero>> GetAllAsync();
        IEnumerable<Genero> Find(Expression<Func<Genero, bool>> expression);
        void Add(Genero entity);
        void AddRange(IEnumerable<Genero> entities);
        void Remove(Genero entity);
        void RemoveRange(IEnumerable<Genero> entities);
        void Update(Genero entity);
    }
