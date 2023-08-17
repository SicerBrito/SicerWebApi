using System.Linq.Expressions;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    private readonly SicerWebApiContext _context;
    
    public GenericRepository(SicerWebApiContext context)
    {
        _context = context;
    }
    
    public void Add(T entity)
    {        
        _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
         _context.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return  _context.Set<T>().Where(expression);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T>? GetByIdAsync(string Id)
    {
        return (await _context.Set<T>().FindAsync(Id))!;
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}
