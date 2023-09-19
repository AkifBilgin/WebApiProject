using System.ComponentModel.DataAnnotations;

namespace HotelProjectWebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Bitte einen Icon Link eingeben")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Bitte einen Titel angeben")]
        [MaxLength(100, ErrorMessage = "Bitte maximal 100 Zeichen benutzen")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bitte eine Beschreibung angeben")]
        [MaxLength(500, ErrorMessage = "Bitte maximal 500 Zeichen benutzen")]
        public string Description { get; set; }
    }
}
