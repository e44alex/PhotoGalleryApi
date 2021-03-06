namespace PhotoGalleryApi.Models
{
    public class User
    {
        public string UserName { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }
    }

    public class UserAccount : User 
    {
        public string HashedPassword { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
