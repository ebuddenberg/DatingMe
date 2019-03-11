using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserForLoginDto{
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength (8,ErrorMessage="You can only have 8 characters in the password")]
        public string Password { get; set; }
    }
}