using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginRequestDTO
    {
        [Required]  
        public string UserName { get; set; }

        [Required] 
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]     
        public string Password { get; set; }
    }
}
