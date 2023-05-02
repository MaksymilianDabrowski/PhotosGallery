namespace PhotosGallery.Models
{
    public class Album
    {
        int Id { get; set; }
        string Name { get; set; }
        string UrlName { get; set; }
        List<Photo> Photos { get; set; }
        public AccessLevel Access { get; set; }
        public string ImageURL { get; set; }
    }
}
