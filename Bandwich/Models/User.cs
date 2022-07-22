using Microsoft.AspNetCore.Identity;

namespace Bandwich.Models;

public class User : IdentityUser
{
    private string _description { get; set; } public string Description { get => _description; set => _description = value; }
    private DateTime _timestamp { get; } public DateTime Timestamp { get => _timestamp; }
    
    private List<string> _imageURLs { get; set; } public List<string> ImageURLs { get => _imageURLs; }

    public User(string description)
    {
        _description = description;
        _timestamp = DateTime.Now;
        _imageURLs = new List<string>();
    }
    
    public List<string> addImage(string imageURL) { _imageURLs.Add(imageURL); return _imageURLs; }
    public List<string> removeImage(string imageURL) { _imageURLs.Remove(imageURL); return _imageURLs; }
}