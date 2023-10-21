﻿using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:38127/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
           return View();
        }

        public async Task<IActionResult> ConfirmBooking(ConfirmReservationDto confirmReservationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(confirmReservationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"http://localhost:38127/api/Booking/ConfirmBooking/?id={confirmReservationDto.BookingID}", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                confirmReservationDto.Status = true;
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");
        }

    }
}
