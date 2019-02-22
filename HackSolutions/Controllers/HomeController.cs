using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackerRank.Models;
using HackSolutions.Models;

namespace HackerRank.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Test()
        {
            TestObj model = new TestObj();
            model.TestList = new List<TestObj>();
            model.TestList.Add(new TestObj("test1", 1));
            model.TestList.Add(new TestObj("test2", 2));
            return View(model);
        }

        [HttpGet]
        public IActionResult Triplet()
        {

            TripletModel model = new TripletModel();
            model.TripletList = new List<TripletModel.Rating>();
            model.TripletList.Add(new TripletModel.Rating("Alice", 0, 0, 0));
            model.TripletList.Add(new TripletModel.Rating("Bob", 100, 100, 100));

            return View(model);
        }
        [HttpPost]
        public IActionResult Triplet(TripletModel model)
        {
            if (model.TripletList == null)
            {
                model.TripletList = new List<TripletModel.Rating>();
                model.TripletList.Add(new TripletModel.Rating("Alice", 0, 0, 0));
                model.TripletList.Add(new TripletModel.Rating("Bob",100, 100, 100));
            }

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
