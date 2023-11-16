using HotelProjectBusinessLayer.Abstract;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void AbideBooking(int id)
        {
            _bookingDal.AbideBooking(id);
        }

        public void BookingStatusChangeApproves(int id)
        {
            _bookingDal.BookingStatusChangeApproves(id);
        }

        public void CancelBooking(int id)
        {
             _bookingDal.CancelBooking(id);
        }

        public int GetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public int GetBookingsWithoutConfirmation()
        {
            return _bookingDal.GetBookingsWithoutConfirmation();
        }

        public List<Booking> GetLastSixBookings()
        {
            return _bookingDal.GetLastSixBookings();
        }

        public void TAdd(Booking entity)
        {
            _bookingDal.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public List<Booking> TGetAll()
        {
            return _bookingDal.GetAll();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
