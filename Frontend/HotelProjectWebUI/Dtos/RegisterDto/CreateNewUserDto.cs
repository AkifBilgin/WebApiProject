using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Bitte einen Vornamen eingeben")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bitte einen Nachnamen eingeben")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bitte einen Useramen eingeben")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bitte einen E-Mail eingeben")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bitte einen Passwort eingeben")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwörter stimmen nicht überein")]
        public string ConfirmPassword { get; set; }
        
    }
}
