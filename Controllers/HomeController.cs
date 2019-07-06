using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using packthat_admin.Models;
using System.Net.Http;

namespace packthat_admin.Controllers
{
    public class HomeController : Controller
    {
        public string apiUrl = "https://packthat-server.herokuapp.com/api/getAllDataForSearch";

        //public async Task<IActionResult> Index()
        //{
            //var allData = await this.GetAllSearchData(); 
         //   return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetAllSearchData()
        {
            string url = "https://packthat-server.herokuapp.com/api/getAllDataForSearch"; // sample url
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri(url);
                var response = await client.GetAsync(uri);
                var resData = await response.Content.ReadAsStringAsync();
                return resData;
            }
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
