﻿using HotelProjectWebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:38127/api/Staff/StaffList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel staff)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(staff);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:38127/api/Staff", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:38127/api/Staff?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();


        }
        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:38127/api/Staff/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateStaffViewModel>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel updateStaffViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateStaffViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:38127/api/Staff/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            { 
            
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
