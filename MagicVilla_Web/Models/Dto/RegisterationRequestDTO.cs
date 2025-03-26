namespace MagicVilla_Web.Models.Dto
{
    public class RegisterationRequestDTO
    {
        #region Properties

        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }

        #endregion
    }
}
