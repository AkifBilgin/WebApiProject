using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values = _testimonialService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddStaff(Testimonial testimonial)
		{
			_testimonialService.TAdd(testimonial);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			var staffToDelete = _testimonialService.TGetById(id);
			_testimonialService.TDelete(staffToDelete);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateStaff(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetStaffById(int id)
		{
			var value = _testimonialService.TGetById(id);
			return Ok(value);
		}
	}
}
