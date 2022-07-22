using System.Security.Claims;
using Bandwich.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Bandwich.Models
{
    public class VenuePrincipalFactory : UserClaimsPrincipalFactory<Venue, IdentityRole>
    {
        public VenuePrincipalFactory(UserManager<Venue> userManager, RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> options) : base(userManager, roleManager, options) {}
        
        public override async Task<ClaimsPrincipal> CreateAsync(Venue venue)
        {
            ClaimsPrincipal principal = await base.CreateAsync(venue);

            if (!string.IsNullOrWhiteSpace(venue.Description))
            {
                ((ClaimsIdentity)principal.Identity)?.AddClaims(new []{new Claim(ClaimTypes.GivenName,venue.Description)});
            }
            if (!string.IsNullOrWhiteSpace(venue.Location))
            {
                ((ClaimsIdentity)principal.Identity)?.AddClaims(new []{new Claim(ClaimTypes.GivenName,venue.Location)});
            }
            return principal;
        }
    }
}

