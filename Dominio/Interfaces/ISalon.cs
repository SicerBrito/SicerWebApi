using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ISalon
    {
        Task<Salon> ? GetByIdAsync(string Id);
        Task<IEnumerable<Salon>> GetAllAsync();
        IEnumerable<Salon> Find(Expression<Func<Salon, bool>> expression);
        void Add(Salon entity);
        void AddRange(IEnumerable<Salon> entities);
        void Remove(Salon entity);
        void RemoveRange(IEnumerable<Salon> entities);
        void Update(Salon entity);
    }
