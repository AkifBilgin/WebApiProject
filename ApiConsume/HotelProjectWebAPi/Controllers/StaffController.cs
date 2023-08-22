
using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values = _staffService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TAdd(staff);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			var staffToDelete = _staffService.TGetById(id);
			_staffService.TDelete(staffToDelete);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetStaffById(int id)
		{
			var value =_staffService.TGetById(id);
			return Ok(value);
		}
	}
}
