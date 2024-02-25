using EvceApi.Business.Models;
using EvceApi.Data.Entities;
using EvceApi.Data.Repositories;

namespace EvceApi.Business.Services;

public class UserService(IUserRepo userRepo) : IUserService
{
    public async Task<IEnumerable<OsusrEvceUtilizador>> GetAllUsersAsync() => await userRepo.GetUsersAsync();
    public async Task<User?> GetUserAsync(string? username)
    {
        var user = await userRepo.GetUserAsync(username);
        
        // Convert the password

        var userDto = new User(user?.Username, user?.Email);

        return userDto;
    }
}