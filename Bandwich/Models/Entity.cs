using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    // Author Laust Eberhardt Bonnesen
    public class Entity
    {
        [Key] public int Id;
        
        private string _title { get; set; } public string Title { get => _title; set => _title = value; }
        private string _description { get; set; } public string Description { get => _description; set => _description = value; }
        private string _email { get; set; } public string Email { get => _email; set => _email = value; }
        private string _phoneNr { get; set; } public string PhoneNr { get => _phoneNr; set => _phoneNr = value; }
        
        private DateTime _timestamp { get; } public DateTime Timestamp { get => _timestamp; }

        public Entity(string title, string description, string email, string phoneNr)
        {
            _title = title;
            _description = description;
            _email = email;
            _phoneNr = phoneNr;
            
            _timestamp = DateTime.Now;
        }
    }
}