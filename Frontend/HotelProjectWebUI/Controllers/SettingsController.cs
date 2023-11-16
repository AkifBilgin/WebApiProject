using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Models.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            EditUserViweModel editUserViweModel = new EditUserViweModel();
            editUserViweModel.FirstName = user.FirstName;
            editUserViweModel.LastName = user.LastName;
            editUserViweModel.Username = user.UserName;
            editUserViweModel.Email = user.Email;
            return View(editUserViweModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(EditUserViweModel editUserViweModel) 
        {
            if(editUserViweModel.Password == editUserViweModel.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.FirstName = editUserViweModel.FirstName;
                user.LastName = editUserViweModel.LastName;
                user.Email = editUserViweModel.Email;
                
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, editUserViweModel.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
