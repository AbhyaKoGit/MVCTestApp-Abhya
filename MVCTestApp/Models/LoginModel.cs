using System.ComponentModel.DataAnnotations;

namespace MVCTestApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="please enter username")]     
        public string Username { get; set; }

        [Required(ErrorMessage = "please enter password")]
        public string Password { get; set; }

      
    }
}
