using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public void AbideBooking(int id)
        {
            using var context = new Context();
            var values = context.Bookings.Find(id);
            if (values.BookingStatus == BookingsStatus.Offen.ToString())
            {
                values.BookingStatus = BookingsStatus.Warten.ToString();
            }

            context.SaveChanges();
        }

        public void BookingStatusChangeApproves(int id)
        {
            using var context = new Context();
            var values = context.Bookings.Find(id);
            if (values.BookingStatus == BookingsStatus.Offen.ToString() || values.BookingStatus == BookingsStatus.Warten.ToString())
            {
                values.BookingStatus = BookingsStatus.Bestätigt.ToString();
            }

            context.SaveChanges();
        }

        public void CancelBooking(int id)
        {
            using var context = new Context();
            var values = context.Bookings.Find(id);
            if(values.BookingStatus == BookingsStatus.Offen.ToString() || values.BookingStatus == BookingsStatus.Warten.ToString() )
            {
                values.BookingStatus = BookingsStatus.Abgelehnt.ToString();
            }
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            using (var context = new Context())
            {
                int count = context.Bookings.Count();
                return count;
            }
        }

        public int GetBookingsWithoutConfirmation()
        {
            using var context = new Context();
            int count = context.Bookings.Where(x=>x.BookingStatus != BookingsStatus.Bestätigt.ToString()).Count();
            return count;
        }

        public List<Booking> GetLastSixBookings()
        {
            using var context = new Context();
            var values = context.Bookings.OrderByDescending(x=>x.BookingID).Take(6).ToList();
            return values;
        }
    }
}
