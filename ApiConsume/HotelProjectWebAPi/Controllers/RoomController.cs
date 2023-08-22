using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			var values = _roomService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.TAdd(room);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteRoom(int id)
		{
			var roomToDelete = _roomService.TGetById(id);
			_roomService.TDelete(roomToDelete);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetRoomById(int id)
		{
			var value = _roomService.TGetById(id);
			return Ok(value);
		}
	}
}
