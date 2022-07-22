using Bandwich.Models;
using Microsoft.AspNetCore.Identity;

namespace Bandwich.entities
{
    // Author Laust Eberhardt Bonnesen
    public class Gig : Entity
    {
        private string _location { get; set; } public string Location { get => _location; set => _location = value; }
        private Venue _venue { get; set; } public Venue Venue { get => _venue; set => _venue = value; } 
        private List<Band> _bands { get; set; } public List<Band> Bands { get => _bands; }

        private DateTime _start { get; set; } public DateTime Start { get => _start; set => _start = value; }
        private DateTime _end { get; set; } public DateTime End { get => _end; set => _end = value; }
        
        public Gig(string title, string description, string email, string phoneNr, string location,
            DateTime start, DateTime end, Venue venue) :
            base(title, description, email, phoneNr)
        {
            _location = location;

            _start = start;
            _end = end;

            _venue = venue;
        }
        
        public List<Band> addBands(List<Band> bands)
        {
            foreach (Band band in bands) { _bands.Add(band); }
            return _bands;
        }
        public List<Band> addBands(Band[] bands)
        {
            foreach (Band band in bands) { _bands.Add(band); }
            return _bands;
        }
        public List<Band> removebands(List<Band> bands)
        {
            foreach (Band band in bands) { _bands.Remove(band); }
            return _bands;
        }
        public List<Band> removebands(Band[] bands)
        {
            foreach (Band band in bands) { _bands.Remove(band); }
            return _bands;
        }
    }
}