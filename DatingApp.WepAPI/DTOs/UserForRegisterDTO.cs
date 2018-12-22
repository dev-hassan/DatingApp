using System.ComponentModel.DataAnnotations;

namespace DatingApp.WepAPI.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8,MinimumLength = 4 ,ErrorMessage ="You must Specify password betwwen 4 and 8 characters")]
        public string Password { get; set; }
        
    }
}