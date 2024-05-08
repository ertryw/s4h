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
            if (id == 0)
                return Json(new RomRoom());

            var room = hotelDbContext.RomRooms.Where(x => x.Id == id).FirstOrDefault();

            return Json(room);
        }

        [HttpDelete]
        public object DeleteRoom(int key)
        {
            using (var context = new S4hHotelonlineContext())
            {
                var room = hotelDbContext.RomRooms.Where(x => x.Id == key).FirstOrDefault();
                context.RomRooms.Remove(room);
                context.SaveChanges();
            }

            return Ok();
        }

        [HttpPost]
        public object InsertRoom(RomRoom newRoom)
        {
            using (var context = new S4hHotelonlineContext())
            {
                int higestNumber = context.RomRooms.Max(x => x.Number);
                var room = new RomRoom() 
                { 
                    Name = newRoom.Name, 
                    Rosid = newRoom.Rosid, 
                    Locid = newRoom.Locid,
                    Phone = newRoom.Phone,
                    FloorNumber = newRoom.FloorNumber,
                    HaveBathroom = newRoom.HaveBathroom,
                    ForPeopleWithDisabilities = newRoom.ForPeopleWithDisabilities,
                    Color = newRoom.Color,
                    IsLocked = newRoom.IsLocked,
                    Shortcut = newRoom.Shortcut,
                    Description = newRoom.Description,
                    Number = higestNumber + 1
                };

                context.Add<RomRoom>(room);
                int updated = context.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public object SetRoom(RomRoom changedRoom)
        {
            using (var context = new S4hHotelonlineContext())
            {
                var entity = context.RomRooms.FirstOrDefault(item => item.Id == changedRoom.Id);

                if (entity != null)
                {
                    // update
                    entity.Name = changedRoom.Name;
                    entity.Rosid = changedRoom.Rosid;
                    entity.Locid = changedRoom.Locid;
                    entity.Phone = changedRoom.Phone;
                    entity.FloorNumber = changedRoom.FloorNumber;
                    entity.HaveBathroom = changedRoom.HaveBathroom;
                    entity.ForPeopleWithDisabilities = changedRoom.ForPeopleWithDisabilities;
                    entity.Color = changedRoom.Color;
                    entity.IsLocked = changedRoom.IsLocked;
                    entity.Shortcut = changedRoom.Shortcut;
                    entity.Description = changedRoom.Description;

                    //context.Update(entity);
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
                , loadOptions);
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
