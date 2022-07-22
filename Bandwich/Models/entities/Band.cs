using Bandwich.Models;

namespace Bandwich.entities
{
    // Author Laust Eberhardt Bonnesen
    public class Band : User
    {
        private string _runner { get; set; } public string Runner { get => _runner; set => _runner = value; }
        private string _area { get; set; } public string Area { get => _area; set => _area = value; }

        private List<BandMember> _bandMembers { get; set; } public List<BandMember> BandMembers { get => _bandMembers; }
        private List<Gig> _gigs { get; set; } public List<Gig> Gigs { get => _gigs; }
        private List<string> _audioURLs { get; set; } public List<string> AudioURLs { get => _audioURLs; }
        private List<string> _imageURLs { get; set; } public List<string> ImageURLs { get => _imageURLs; }

        // Constructors
        public Band(string description, string area) : base(description)
        {
            _area = area;
            _runner = "";

            _gigs = new List<Gig>();
            _audioURLs = new List<string>();            
        }
        public Band(string description, string area, string runner) : base(description)
        {
            _area = area;
            _runner = runner;

            _gigs = new List<Gig>();
            _audioURLs = new List<string>();
            _imageURLs = new List<string>();
        }

        public List<BandMember> addMembers(List<BandMember> members)
        {
            foreach (BandMember member in members) { _bandMembers.Add(member); }
            return _bandMembers;
        }
        public List<BandMember> addMembers(BandMember[] members)
        {
            foreach (BandMember member in members) { _bandMembers.Add(member); }
            return _bandMembers;
        }
        public List<BandMember> removeMembers(List<BandMember> members)
        {
            foreach (BandMember member in members) { _bandMembers.Remove(member); }
            return _bandMembers;
        }
        public List<BandMember> removeMembers(BandMember[] members)
        {
            foreach (BandMember member in members) { _bandMembers.Remove(member); }
            return _bandMembers;
        }
        public List<Gig> addGig(Gig gig) { _gigs.Add(gig); return _gigs; }
        public List<Gig> RemoveGig(Gig gig) { _gigs.Remove(gig); return _gigs; }
        public List<string> addAudio(string audioURL) { _audioURLs.Add(audioURL); return _audioURLs; }
        public List<string> removeAudio(string audioURL) { _audioURLs.Remove(audioURL); return _audioURLs; }
    }
}