using System.Diagnostics;
using DotNetTrainingBatch5.Project1.MvcApp.Models;
using DotNetTrainingBatch5.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetTrainingBatch5.Project1.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientService _httpClientService;

        public HomeController(ILogger<HomeController> logger, IHttpClientService httpClientService)
        {
            _logger = logger;
            _httpClientService = httpClientService;
        }

        public async Task<IActionResult> Index()
        {
            var lst = await _httpClientService.SendAsync<List<BlogModel>>("api/blog", EnumHttpMethod.Get);
            _logger.LogInformation(JsonConvert.SerializeObject(lst));
            return View(lst);
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

    public class BlogModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
