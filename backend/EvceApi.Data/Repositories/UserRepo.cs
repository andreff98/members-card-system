using EvceApi.Data.Context;
using EvceApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvceApi.Data.Repositories;

public class UserRepo(EvceContext evceContext) : IUserRepo
{
    public async Task<IEnumerable<OsusrEvceUtilizador>> GetUsersAsync()
    {
        IEnumerable<OsusrEvceUtilizador> users = await evceContext.Users.ToListAsync();
        return users;
    }

    public async Task<OsusrEvceUtilizador?> GetUserAsync(string? username)
    {
        var user = await evceContext.Users.FirstOrDefaultAsync(x => x.Username == username);
        return user;
    }
}