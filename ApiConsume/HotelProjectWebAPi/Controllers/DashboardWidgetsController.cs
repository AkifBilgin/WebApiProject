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

        public DashboardWidgetsController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount() 
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }
    }
}
