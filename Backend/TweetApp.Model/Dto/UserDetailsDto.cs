#nullable disable

using TweetApp.Repository.Entities;

namespace TweetApp.Model.Dto
{
    public class UserDetailsDto
    {
        public int LoginId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ContactNumber { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public string Image { get; set; } = string.Empty;

    }
}
