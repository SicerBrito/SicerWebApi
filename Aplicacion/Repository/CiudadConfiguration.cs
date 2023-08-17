using System.Linq.Expressions;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repository;
public class CiudadConfiguration : IGenericRepository<Ciudad>
{
    public void Add(Ciudad entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Ciudad> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ciudad> Find(Expression<Func<Ciudad, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ciudad>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Ciudad>? GetByIdAsync(string Id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Ciudad entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Ciudad> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Ciudad entity)
    {
        throw new NotImplementedException();
    }
}
