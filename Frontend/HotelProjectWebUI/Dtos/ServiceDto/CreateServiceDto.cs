using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Bitte einen Icon Link eingeben")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Bitte einen Titel angeben")]
        [MaxLength(100,ErrorMessage ="Bitte maximal 100 Zeichen benutzen")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

