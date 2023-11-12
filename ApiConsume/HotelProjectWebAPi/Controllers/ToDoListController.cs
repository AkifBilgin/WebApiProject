using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        [HttpGet]
        public IActionResult GetToDoList()
        {
            var values = _toDoListService.TGetAll();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteToDoList(int id) 
        {
            var value = _toDoListService.TGetById(id);
            _toDoListService.TDelete(value);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddToDo(ToDoList toDoList)
        {
            _toDoListService.TAdd(toDoList);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateToDo(ToDoList toDoList)
        {
            _toDoListService.TUpdate(toDoList);
            return Ok();
        }
    }
}
