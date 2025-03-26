using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        //[Required]   
        public UserDTO User { get; set; }
       
        //[Required]  
        public string Token { get; set; }
    }
}
