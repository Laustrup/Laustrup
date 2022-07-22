using Bandwich.Models;
using Microsoft.AspNetCore.Identity;

namespace Bandwich.entities
{
    // Author Laust Eberhardt Bonnesen
    public class Venue : User
    {
        [PersonalData]
        private string _location { get; set; } public string Location { get => _location; set => _location = value; }
        
        [PersonalData]
        private List<Gig> _gigs { get; set; } public List<Gig> Gigs { get => _gigs; }
        
        [PersonalData]
        private DateTime _established { get; } public DateTime Established { get => _established; }

        public Venue(string description, string location, DateTime established) : base(description)
        {
            _location = location;
            _established = established;
            _gigs = new List<Gig>();
        }
    }
}