using Golbet.Entities.Common;
// GolBet.Repositories/Interfaces/IGenericRepository.cs

namespace GolBet.Repositories.Interfaces;

/// <summary>
/// Generic data-access contract for all domain entities.
/// Specific queries live in entity-specific repositories.
/// </summary>
public interface IGenericRepository<T> where T : AuditableEntity
{
    // ---- Queries ----
    //Metodo 1
    Task<IEnumerable<T>> GetAllAsync(bool includeInactive = false);
    //Metodo 2
    Task<T?> GetByIdAsync(int id);

    // ---- Commands ----
    //Metodo 3
    Task<T> AddAsync(T entity);
    //Metodo 4
    Task UpdateAsync(T entity);
    //Metodo 5
    Task DeactivateAsync(int id);   // logical delete: IsActive = false
}
