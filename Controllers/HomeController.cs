using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DessertIsland.Models;
using DessertIsland.DAL;

namespace DessertIsland.Controllers
{
    public class HomeController : Controller
    {
        private IDessertsSQLDAO DessertsDAO;
        private IClickSQLDAO ClicksDAO;

        public HomeController(IDessertsSQLDAO dessertsDAO, IClickSQLDAO clicksDAO)
        {
            this.DessertsDAO = dessertsDAO;
            this.ClicksDAO = clicksDAO;
        }

        public IActionResult Index()
        {
            IList<Dessert> desserts = DessertsDAO.GetAllDesserts();
            return View(desserts);
        }

        public IActionResult Hashtag(string hashtag)
        {
            IList<Dessert> desserts = DessertsDAO.GetAllDesserts();
            List<Dessert> hashtagDesserts = new List<Dessert>();
            foreach (Dessert dessert in desserts)
            {
                if (dessert.HashTag1 == hashtag || dessert.HashTag2 == hashtag || dessert.HashTag3 == hashtag ||
                    dessert.HashTag4 == hashtag || dessert.HashTag5 == hashtag || dessert.HashTag6 == hashtag ||
                    dessert.HashTag7 == hashtag || dessert.HashTag8 == hashtag || dessert.HashTag9 == hashtag ||
                    dessert.HashTag10 == hashtag)
                {
                    hashtagDesserts.Add(dessert);
                }
            }
            return View(hashtagDesserts);
        }
        [HttpPost]
        public IActionResult AddALike(int dessertId)
        {
            ClicksDAO.AddClick(dessertId);
            return RedirectToAction("Index");
        }
        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
