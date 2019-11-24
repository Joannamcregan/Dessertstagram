using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DessertIsland.DAL;
using DessertIsland.Models;
using Microsoft.AspNetCore.Mvc;

namespace DessertIsland.Controllers
{
    public class InputController : Controller
    {
        private IClickSQLDAO ClicksDAO;

        public InputController(IClickSQLDAO clicksDAO)
        {
            this.ClicksDAO = clicksDAO;
        }

        public IActionResult SubmitNewDessert()
        {
            return View();
        }
        
    }
}