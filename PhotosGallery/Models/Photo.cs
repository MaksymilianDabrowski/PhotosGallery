namespace PhotosGallery.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Author { get; set; }
        public List<string>? Tags { get; set; }
        public string? Camera { get; set; }
        public string? Details { get; set; }
        public AccessLevel Access { get; set; }
        public List<Comment>? Comments { get; set; } 
        public string ImageURL { get; set; }
        
        // do przemyślenia 
        public int UpVote { get; set; } 
        public int DownVote { get; set; }


    }
}
