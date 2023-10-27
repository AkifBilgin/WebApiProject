using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        [HttpGet]
        public IActionResult GetMessageCategory()
        {
           var values = _messageCategoryService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.TAdd(messageCategory);
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var value = _messageCategoryService.TGetById(id);
            _messageCategoryService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.TUpdate(messageCategory);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageCategorieById(int id) 
        {
            var value = _messageCategoryService.TGetById(id);
            return Ok(value);
        }
    }
}
