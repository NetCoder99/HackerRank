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
            model = new TestObj("test1");
            return View(model);
        }

        [HttpPost]
        public IActionResult Test(TestObj model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Triplet()
        {

            TripletModel model = new TripletModel();
            model.TripletList = new List<TripletModel.Rating>();
            model.TripletList.Add(new TripletModel.Rating("Alice", 0, 1, 1));
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

            int[] winner = new int[] { 0, 0 };

            if (model.TripletList[0].rating1 > model.TripletList[1].rating1) { winner[0]++; }
            if (model.TripletList[0].rating1 < model.TripletList[1].rating1) { winner[1]++; }

            if (model.TripletList[0].rating2 > model.TripletList[1].rating2) { winner[0]++; }
            if (model.TripletList[0].rating2 < model.TripletList[1].rating2) { winner[1]++; }

            if (model.TripletList[0].rating3 > model.TripletList[1].rating3) { winner[0]++; }
            if (model.TripletList[0].rating3 < model.TripletList[1].rating3) { winner[1]++; }

            ViewData["winner_array"] = winner;
            ViewData["winner_name"] = "Tied";
            if (winner[0] > winner[1]) { ViewData["winner_name"] = "Alice"; }
            if (winner[0] < winner[1]) { ViewData["winner_name"] = "Bob"; }

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
