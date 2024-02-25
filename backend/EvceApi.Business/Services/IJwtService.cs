namespace EvceApi.Business.Services;

public interface IJwtService
{
    string? GenerateJwtToken(string? username);
}