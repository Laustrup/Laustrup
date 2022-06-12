using System;
using Models;

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public class Gig : Entity
    {
        private string _location { get; set; } public string Location { get => _location; set => _location = value; }
        private string _imageURL { get; set; } public string ImageURL { get => _imageURL; set => _imageURL = value; }
        
        private DateTime _start { get; set; } public DateTime Start { get => _start; set => _start = value; }
        private DateTime _end { get; set; } public DateTime End { get => _end; set => _end = value; }
        
        public Gig(string title, string description, string email, string phoneNr, string location,
            DateTime start, DateTime end) :
            base(title, description, email, phoneNr)
        {
            _location = location;

            _start = start;
            _end = end;
        }
    }
}