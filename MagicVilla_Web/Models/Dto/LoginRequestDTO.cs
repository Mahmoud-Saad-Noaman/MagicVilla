using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class LoginRequestDTO
    {
        //[Required(ErrorMessage = "User Name is required")]     
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Password is required")]    
        //[MinLength(6, ErrorMessage = "Password must be at least 6 characters")]     
        public string Password { get; set; }
    }
}
