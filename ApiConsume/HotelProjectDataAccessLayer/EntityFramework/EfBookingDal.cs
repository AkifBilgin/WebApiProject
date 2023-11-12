﻿using HotelProjectDataAccessLayer.Abstract;
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
           using var context = new Context();
            var value = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            if(value.Status == false)
                value.Status = true;

            if(value.Status == true)
                value.Status = false;
            context.SaveChanges();
        }

        public void ConfirmBookingStatus2(int id)
        {
            using var context = new Context();
            var value = context.Bookings.Find(id);
            if (value.Status == false)
                value.Status = true;

            if (value.Status == true)
                value.Status = false;
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
            int count = context.Bookings.Where(x=>x.Status == false).Count();
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
