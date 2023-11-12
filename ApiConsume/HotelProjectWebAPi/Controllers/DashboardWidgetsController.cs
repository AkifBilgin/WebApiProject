using HotelProjectBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly ISubscribeService _subscribeService;

        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, ISubscribeService subscribeService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _subscribeService = subscribeService;
        }
        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount() 
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }

        [HttpGet("GetBookingCount")]
        public IActionResult GetBookingCount()
        {
            var count = _bookingService.GetBookingCount();
            return Ok(count);
        }
        [HttpGet("GetSubscribeCount")]
        public IActionResult GetSubscribeCount()
        {
            var count = _subscribeService.SubscribeCount();
            return Ok(count);
        }
        [HttpGet("GetBookingsWithoutConfirmation")]
        public IActionResult GetBookingsWithoutConfirmation()
        {
            var count = _bookingService.GetBookingsWithoutConfirmation();
            return Ok(count);
        }
    }
}
