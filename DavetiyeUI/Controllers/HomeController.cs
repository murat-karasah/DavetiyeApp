using DavetiyeUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DavetiyeEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DavetiyeEkle(DavetiyeDto davetiye)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/api/");
            var stringDavetiye = new StringContent(JsonConvert.SerializeObject(davetiye), Encoding.UTF8, "application/json");
            var result = client.PostAsync("Davetiye", stringDavetiye);
            result.Wait();
            return RedirectToAction("Liste","Home");
        }

        public IActionResult Liste()
        {
            List<DavetiyeDto> dList = new List<DavetiyeDto>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/api/");
            var responseTalk = client.GetAsync("Davetiye");
            var result = responseTalk.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                var davetiyes = readTask.Result;
                dList = JsonConvert.DeserializeObject<List<DavetiyeDto>>(davetiyes);
            }
            if (dList!=null)
            {
                return View(dList);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/api/");
            var result = client.DeleteAsync("Davetiye" + "/" + id).Result;
            return RedirectToAction("Liste", "Home");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            DavetiyeDto davetiye = new DavetiyeDto();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:44390/api/");
            var respomseTalk = client.GetAsync("Davetiye" + "/" + id);
            respomseTalk.Wait();
            var result = respomseTalk.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var davetiyes = readTask.Result;
                davetiye = JsonConvert.DeserializeObject<DavetiyeDto>(davetiyes);
            }
            if (davetiye!=null)
            {
                return View(davetiye);
            }
            return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
