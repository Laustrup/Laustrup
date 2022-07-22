using Bandwich.Models;

namespace Bandwich.entities
{
    // Author Laust Eberhardt Bonnesen
    public class Venue : Entity
    {
        private string _location { get; set; } public string Location { get => _location; set => _location = value; }
        
        private List<Gig> _gigs { get; set; } public List<Gig> Gigs { get => _gigs; }
        
        private DateTime _established { get; } public DateTime Established { get => _established; }

        public Venue(string title, string description, string email, string phoneNr, string location, DateTime established) :
            base(title, description, email, phoneNr)
        {
            _location = location;

            _established = established;

            _gigs = new List<Gig>();
        }
    }
}