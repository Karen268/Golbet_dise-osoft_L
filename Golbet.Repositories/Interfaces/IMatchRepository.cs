
// GolBet.Repositories/Interfaces/IMatchRepository.cs
using Golbet.Entities.Enums;
using Golbet.Entities;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
}
