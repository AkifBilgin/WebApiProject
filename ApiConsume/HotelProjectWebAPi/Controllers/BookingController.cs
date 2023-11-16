using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GettAllBookings()
        {
           var values =  _bookingService.TGetAll();
            return Ok(values);
        }
        [HttpGet("GetLastSixBookings")]
        public IActionResult GetLastSixBookings()
        {
            var values = _bookingService.GetLastSixBookings();
            return Ok(values);
        }

        [HttpPost("AddBooking")]
        public IActionResult AddBooking(Booking booking)
        {
            booking.BookingStatus = BookingsStatus.Offen.ToString();
            _bookingService.TAdd(booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
           var bookingToDelete =  _bookingService.TGetById(id);
            _bookingService.TDelete(bookingToDelete);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdBooking(int id) 
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }


        [HttpGet("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            _bookingService.BookingStatusChangeApproves(id);
            return Ok();
        }
        [HttpGet("CancelBooking")]
        public IActionResult CancelBooking(int id)
        {
            _bookingService.CancelBooking(id);
            return Ok();
        }

        [HttpGet("AbideBooking")]
        public IActionResult AbideBooking(int id)
        {
            _bookingService.AbideBooking(id);
            return Ok();
        }
    }
}
