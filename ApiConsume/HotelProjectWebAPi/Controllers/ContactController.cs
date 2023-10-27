using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var values = _contactService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TAdd(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetContactMessageById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);

        }

        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
           var value = _contactService.TGetContactCount();
            return Ok(value);
        }
    }
}
