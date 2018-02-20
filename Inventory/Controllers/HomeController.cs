using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/")]
        public ActionResult IndexPost()
        {

            return View("Results", Item.GetAll());
        }
        [HttpPost("/AddItem")]
        public ActionResult AddItem()
        {
            string description = Request.Form["description"];
            Item newItem = new Item(description, 0);
            newItem.Save();


            return View("Index");
        }
    }
}
