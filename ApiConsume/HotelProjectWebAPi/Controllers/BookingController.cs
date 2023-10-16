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
        [HttpPost("AddBooking")]
        public IActionResult AddBooking(Booking booking)
        {
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

        [HttpPut("ConfirmBooking")]
        public IActionResult ConfirmBooking(Booking booking)
        {
             _bookingService.ConfirmBookingStatus(booking);
            return Ok();
        }

        [HttpPut("ConfirmBooking2")]
        public IActionResult ConfirmBooking2(int id)
        {
            _bookingService.ConfirmBookingStatus2(id);
            return Ok();
        }
    }
}
