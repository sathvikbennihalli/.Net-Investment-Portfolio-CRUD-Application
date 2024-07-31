using api.Models;

namespace api.Interfaces
{
    public interface ITokenService
    {
        String CreateToken(AppUser user);
    }
}