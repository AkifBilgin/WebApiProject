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
        void ConfirmBookingStatus(Booking booking);
        void ConfirmBookingStatus2(int id);
        int GetBookingCount();
        int GetBookingsWithoutConfirmation();
        List<Booking> GetLastSixBookings();

    }
}
