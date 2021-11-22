namespace PhotoGalleryApi.Models
{
    public class Photo
    {
        public Guid PhotoId { get; set; }

        public string PhotoName { get; set; }

        public User Author { get; set; }

        public string PhotoURL { get; set; }
    }
}
