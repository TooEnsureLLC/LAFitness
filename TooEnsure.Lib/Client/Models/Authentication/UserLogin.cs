using System.ComponentModel.DataAnnotations;

namespace TooEnsure.Lib.Client.Models.Authentication
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}