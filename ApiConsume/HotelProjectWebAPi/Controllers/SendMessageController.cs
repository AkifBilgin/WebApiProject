using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendmessageService;

        public SendMessageController(ISendMessageService sendMessage)
        {
            _sendmessageService = sendMessage;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendmessageService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendmessageService.TAdd(sendMessage);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var staffToDelete = _sendmessageService.TGetById(id);
            _sendmessageService.TDelete(staffToDelete);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendmessageService.TUpdate(sendMessage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessageById(int id)
        {
            var value = _sendmessageService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("GetMessageCount")]
        public IActionResult GetMessageCount()
        {
            var value = _sendmessageService.TGetSendMessageCount();
            return Ok(value);
        }
    }
}
