using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _aboutUsService.TGetAll();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.TAdd(aboutUs);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAboutUs(AboutUs aboutUs)
        {
            var aboutUsToDelete = _aboutUsService.TGetById(aboutUs.AboutUsID);
            _aboutUsService.TDelete(aboutUsToDelete);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.TUpdate(aboutUs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var value = _aboutUsService.TGetById(id);
            return Ok(value);
        }
    }
}
