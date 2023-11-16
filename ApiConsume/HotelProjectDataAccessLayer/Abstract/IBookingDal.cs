using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        int GetBookingCount();
        int GetBookingsWithoutConfirmation();
        List<Booking> GetLastSixBookings();
        void BookingStatusChangeApproves(int id);
        void CancelBooking(int id);
        void AbideBooking(int id);

    }
}
