using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using HotelProjectWebUI.Dtos.SocialMediaDto;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class _DashboardSocialMediaPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/besiktas"),
                Headers =
    {
        { "X-RapidAPI-Key", "4d7bcf427bmsha3cee8821db91cbp13e07fjsn570d9fa0881e" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<InstagramDto>(body);
                ViewBag.followers = jsonData.followers;
                ViewBag.following = jsonData.following;
                
            }

         
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=DarkWebHaber&user_id=96479162"),
                Headers =
    {
        { "X-RapidAPI-Key", "4d7bcf427bmsha3cee8821db91cbp13e07fjsn570d9fa0881e" },
        { "X-RapidAPI-Host", "twitter154.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var twitterData = JsonConvert.DeserializeObject<TwitterDto>(body2);
                ViewBag.twitterFollower = twitterData.follower_count;
                ViewBag.twitterFollowing = twitterData.following_count;
            }



            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fwilliamhgates%2F&include_skills=false"),
                Headers =
    {
        { "X-RapidAPI-Key", "4d7bcf427bmsha3cee8821db91cbp13e07fjsn570d9fa0881e" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var linkedIn = JsonConvert.DeserializeObject<LinkedInDto>(body3);
                ViewBag.linkedIn = linkedIn.data.followers_count;
            }
            return View();
        }


    }
}
