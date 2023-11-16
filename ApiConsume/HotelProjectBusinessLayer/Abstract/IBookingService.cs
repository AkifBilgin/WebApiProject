using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        int GetBookingCount();
        int GetBookingsWithoutConfirmation();
        List<Booking> GetLastSixBookings();
        void BookingStatusChangeApproves(int id);
        public void CancelBooking(int id);
        public void AbideBooking(int id);
    }
}
