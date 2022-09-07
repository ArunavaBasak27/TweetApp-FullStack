using System.ComponentModel.DataAnnotations;
#nullable disable
namespace TweetApp.Model.Dto
{
    public class ForgotPassword
    {
        [Required]
        public string Password { get; set; }
    }
}
