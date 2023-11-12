using HotelProjectWebUI.Dtos.ToDoListDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ToDoListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddTask()
        {
          
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddTask(CreateToDoListDto createToDoListDto)
        {
            createToDoListDto.Status = false;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createToDoListDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8,"application/json");

            await client.PostAsync("http://localhost:38127/api/ToDoList", stringContent);
            
            return RedirectToAction("Index", "AdminDashboard");
            
        }
        public async Task<IActionResult> DeleteTask(int id)
        {
            var client= _httpClientFactory.CreateClient();
            await client.DeleteAsync($"http://localhost:38127/api/ToDoList?id={id}");
            return RedirectToAction("Index", "AdminDashboard");

        }
    }
}
