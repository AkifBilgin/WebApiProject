using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; } 
        [Required(ErrorMessage = "Zimmernummer darf nicht leer sein")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Preis darf nicht leer sein")]
        
        public decimal PricePerNight { get; set; }

        [Required(ErrorMessage = "Bitte eine Überschrift hinzufügen")]
        [MaxLength(100,ErrorMessage ="Bitte maximal 100 Zeichen eingeben")]
        public string Title { get; set; }

        public string BedCount { get; set; }

        public string BathCount { get; set; }

        public string Wifi { get; set; }
        [Required(ErrorMessage ="Bitte eine Beschreibung hinzufügen")]
        public string Description { get; set; }
    }
}
