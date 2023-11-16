using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectEntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string BookingStatus { get; set; }
    }
    public enum BookingsStatus
    {
        Bestätigt,
        Offen,
        Abgelehnt,
        Warten
    }
}
