using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;

		}

		[HttpGet]
		public IActionResult GetAll() 
		{
			var values = _serviceService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddService(Service service) 
		{
			_serviceService.TAdd(service);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteService(int id)
		{
			var serviceToDelete = _serviceService.TGetById(id);
			_serviceService.TDelete(serviceToDelete);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateService(Service service) 
		{
			_serviceService.TUpdate(service);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetServiceByID(int id)
		{
			var value = _serviceService.TGetById(id);
			return Ok(value);
		}

	}
}
