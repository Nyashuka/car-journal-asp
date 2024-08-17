using System.Security.Claims;

namespace CarJournal.Services.Authentication;

public interface IClientAuthenticationService
{
    Task UpdateSessionStorage(string jwtToken);
}