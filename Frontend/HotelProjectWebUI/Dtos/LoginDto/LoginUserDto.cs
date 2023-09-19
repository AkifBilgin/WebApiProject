using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Bitte Username eingeben")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Bitte Passwort eingeben")]
        public string Password { get; set; }
    }
}
