using Bandwich.Models;

namespace Bandwich.entities
{
    // Author Laust Eberhardt Bonnesen
    public class BandMember : Entity
    {
        public string FullName { get => _firstName + " " + _lastName; }
        private string _firstName { get; set; } public string FirstName { get => _firstName; set => _firstName = value; }
        private string _lastName { get; set; } public string LastName { get => _lastName; set => _lastName = value; }
        private List<Band> _bands { get; set; } public List<Band> Bands { get => _bands; }

        public BandMember(string title, string firstName, string lastName, string description, 
            string email, string phoneNr) : base(title, description, email, phoneNr)
        {
            _firstName = firstName;
            _lastName = lastName;

            _bands = new List<Band>();
        }
        
        public BandMember(string firstName, string lastName, string description, 
            string email, string phoneNr) : base(firstName + " " + lastName, description, email, phoneNr)
        {
            _firstName = firstName;
            _lastName = lastName;

            _bands = new List<Band>();
        }

        public BandMember(string title, string description, string email, string phoneNr) : base(title, description, email,
            phoneNr)
        {
            _bands = new List<Band>();
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
        public List<Band> removeBands(List<Band> bands)
        {
            foreach (Band band in bands) { _bands.Remove(band); }
            return _bands;
        }
        public List<Band> removeBands(Band[] bands)
        {
            foreach (Band band in bands) { _bands.Remove(band); }
            return _bands;
        }
    }
}
