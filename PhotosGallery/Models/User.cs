using System.ComponentModel.DataAnnotations;

namespace PhotosGallery.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
    }
}
