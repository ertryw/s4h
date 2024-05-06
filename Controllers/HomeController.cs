using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.NETCore.Demos.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using s4h.Models;
using System.Diagnostics;

namespace s4h.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly S4hHotelonlineContext hotelDbContext;

        public HomeController(ILogger<HomeController> logger, S4hHotelonlineContext hotelDbContext)
        {
            _logger = logger;
            this.hotelDbContext = hotelDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public object GetRooms(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(hotelDbContext.RomRooms, loadOptions);
        }

        [HttpGet]
        public object GetItems(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(TreeViewPlainData.Items, loadOptions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
