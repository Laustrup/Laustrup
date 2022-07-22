using System.Security.Claims;
using Bandwich.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Bandwich.Models
{
    public class PrincipalFactory : UserClaimsPrincipalFactory<Band, IdentityRole>
    {
        public PrincipalFactory(UserManager<Band> userManager, RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options) : base(userManager, roleManager, options) {}

        public override async Task<ClaimsPrincipal> CreateAsync(Band band)
        {
            ClaimsPrincipal principal = await base.CreateAsync(band);

            if (!string.IsNullOrWhiteSpace(band.Description))
            {
                ((ClaimsIdentity)principal.Identity)?.AddClaims(new []{new Claim(ClaimTypes.GivenName,band.Description)});
            }
            if (!string.IsNullOrWhiteSpace(band.Area))
            {
                ((ClaimsIdentity)principal.Identity)?.AddClaims(new []{new Claim(ClaimTypes.GivenName,band.Area)});
            }
            if (!string.IsNullOrWhiteSpace(band.Runner))
            {
                ((ClaimsIdentity)principal.Identity)?.AddClaims(new []{new Claim(ClaimTypes.GivenName,band.Runner)});
            }
            return principal;
        }
    }
}