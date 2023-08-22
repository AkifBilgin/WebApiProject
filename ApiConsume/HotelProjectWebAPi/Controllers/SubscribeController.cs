using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;

		public SubscribeController(ISubscribeService subscribeService)
		{
			_subscribeService = subscribeService;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			var values = _subscribeService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddSubscribe(Subscribe subscribe)
		{
			_subscribeService.TAdd(subscribe);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteSubscribe(int id)
		{
			var subscribeToDelete = _subscribeService.TGetById(id);
			_subscribeService.TDelete(subscribeToDelete);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe subscribe)
		{
			_subscribeService.TUpdate(subscribe);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetSubscribeById(int id)
		{
			var value = _subscribeService.TGetById(id);
			return Ok(value);
		}
	}
}
