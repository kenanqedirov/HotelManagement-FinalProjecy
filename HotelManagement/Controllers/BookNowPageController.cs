﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Authorize(Roles ="Member,Admin")]
    [Route("[controller]/[action]")]
    public class BookNowPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
