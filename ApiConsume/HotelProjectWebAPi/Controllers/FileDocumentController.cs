using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;

namespace HotelProjectWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDocumentController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> UploadDocument([FromForm] IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"Documents/{fileName}");
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created(path, file);
        }
    }
}
