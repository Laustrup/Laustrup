using System.Collections.Generic;
using Models;

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public class Band : Entity
    {
        private string _runner { get; set; } public string Runner { get => _runner; set => _runner = value; }
        private string _area { get; set; } public string Area { get => _area; set => _area = value; }
        
        private List<Gig> _gigs { get; set; } public List<Gig> Gigs { get => _gigs; }
        private List<string> _audioURLs { get; set; } public List<string> AudioURLs { get => _audioURLs; }
        private List<string> _imageURLs { get; set; } public List<string> ImageURLs { get => _imageURLs; }

        // Constructors
        public Band(string title, string description, string area, string email, string phoneNr) :
            base(title, description, email, phoneNr)
        {
            _area = area;
            _runner = "";

            _gigs = new List<Gig>();
            _audioURLs = new List<string>();            
        }
        public Band(string title, string description, string area, string runner, string email, string phoneNr) :
            base(title, description, email, phoneNr)
        {
            _area = area;
            _runner = runner;

            _gigs = new List<Gig>();
            _audioURLs = new List<string>();
            _imageURLs = new List<string>();
        }
    }
}