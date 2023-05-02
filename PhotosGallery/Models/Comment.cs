namespace PhotosGallery.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public User Author { get; set; }
        public string Comments { get; set; } // dodać relację pomiędzy commentid a photoid

    }
}
