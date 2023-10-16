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
        public void ConfirmBookingStatus(Booking booking)
        {
            var context = new Context();
            var value = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            if(value.Status == false)
                value.Status = true;

            if(value.Status == true)
                value.Status = false;
            context.SaveChanges();
        }

        public void ConfirmBookingStatus2(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            if (value.Status == false)
                value.Status = true;

            if (value.Status == true)
                value.Status = false;
            context.SaveChanges(); 
        }
    }
}
