using EvceApi.Data.Entities;

namespace EvceApi.Data.Repositories;

public interface IUserRepo
{
    Task<IEnumerable<OsusrEvceUtilizador>> GetUsersAsync();
    
    Task<OsusrEvceUtilizador?> GetUserAsync(string? username);
}