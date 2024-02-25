using EvceApi.Business.Models;
using EvceApi.Data.Entities;

namespace EvceApi.Business.Services;

public interface IUserService
{
    Task<IEnumerable<OsusrEvceUtilizador>> GetAllUsersAsync();
    
    Task<User?> GetUserAsync(string? username);
}