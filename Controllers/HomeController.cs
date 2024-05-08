using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.NETCore.Demos.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public object GetStandards(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(hotelDbContext.RosRoomStandards, loadOptions);
        }

        [HttpGet]
        public object GetLocs(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(hotelDbContext.LocLocals, loadOptions);
        }

        [HttpGet]
        public object GetLocationsAndStandards()
        {
            var roomStandards = hotelDbContext.RosRoomStandards.ToList();
            var locations = hotelDbContext.LocLocals.ToList();

            return Json(new object[] { roomStandards, locations });
        }

        [HttpGet]
        public object GetRoom(int id)
        {
            var room = hotelDbContext.RomRooms.Where(x => x.Id == id).FirstOrDefault();

            return Json(room);
        }

        [HttpPost]
        public object InsertRoom(RomRoom room)
        {
            //using (var context = new S4hHotelonlineContext())
            //{
            //    var author = new RomRoom() { Name = "Pokój nr. 0", Rosid = 1, Locid = 1};
            //    context.Add<RomRoom>(author);
            //    int updated = context.SaveChanges();
            //}

            return Ok();
        }

        [HttpPut]
        public object SetRoom(RomRoom room)
        {
            using (var context = new S4hHotelonlineContext())
            {
                var entity = context.RomRooms.FirstOrDefault(item => item.Id == room.Id);

                if (entity != null)
                {
                    // update
                    context.SaveChanges();
                }
            }

            return Ok();
        }

        [HttpGet]
        public object GetRooms(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(hotelDbContext.RomRooms
                .Include(x => x.Ros)
                .Include(x => x.Loc)
                ,loadOptions);
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
