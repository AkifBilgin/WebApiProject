using AutoMapper;
using HotelProjectBusinessLayer.Abstract;
using HotelProjectDtoLayer.Dtos.RoomDto;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomservice;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomservice, IMapper mapper)
        {
            _roomservice = roomservice;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomservice.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(roomAddDto);
            _roomservice.TAdd(value);
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(roomUpdateDto);
            _roomservice.TUpdate(value);
            return Ok();    
        }
    }
}
