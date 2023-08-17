using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ITrainerSalon
    {
        Task<Departamento> ? GetByIdAsync(string Id);
        Task<IEnumerable<Departamento>> GetAllAsync();
        IEnumerable<Departamento> Find(Expression<Func<Departamento, bool>> expression);
        void Add(Departamento entity);
        void AddRange(IEnumerable<Departamento> entities);
        void Remove(Departamento entity);
        void RemoveRange(IEnumerable<Departamento> entities);
        void Update(Departamento entity);
    }
