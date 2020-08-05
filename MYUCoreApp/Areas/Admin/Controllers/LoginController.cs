﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYUCoreApp.Areas.Admin.Models;
using MYUCoreApp.Data.Entities;
using MYUCoreApp.Utilities.Dtos;
using System.Threading.Tasks;

namespace MYUCoreApp.Areas.Admin.Controllers
{
    public class LoginController: Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger _logger;
        public LoginController(UserManager<AppUser> userManager,
                               SignInManager<AppUser> signInManager,
                               ILogger<LoginController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authen(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RemmemberMe,lockoutOnFailure:false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return new OkObjectResult(new GenericResult(true));
                }
                if (result.IsLockedOut)
                {
                        _logger.LogWarning("User account locked out");
                    return new ObjectResult(new GenericResult(false,"Tài khoản đã bị khóa"));
                }
                else
                {
                    return new ObjectResult(new GenericResult(false,"Đăng nhập sai"));
                }
            }
            return new ObjectResult(new GenericResult(false,model));
        }
        
    }
}
