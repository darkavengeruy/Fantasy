using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Fantasy.Frontend.AuthenticationProviders;

public class AuthenticationProviderTest : AuthenticationStateProvider
{
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        await Task.Delay(3000);

        var anonimous = new ClaimsPrincipal();
        var user = new ClaimsIdentity(authenticationType: "test");
        var admin = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FistName", "Fernando"),
            new Claim("LastName", "Franco"),
            new Claim(ClaimTypes.Name, "ffranco@adinet.com.uy"),
            new Claim(ClaimTypes.Role, "Admin"),
        },
        authenticationType: "test");

        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(admin)));
    }
}