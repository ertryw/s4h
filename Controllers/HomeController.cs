using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.NETCore.Demos.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s4h.Models;
using s4h.Repositories;
using s4h.Services;
using System.Diagnostics;

namespace s4h.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRoomRepository roomRepository;
        private ILocalsService localsService;

        public HomeController(ILogger<HomeController> logger, IRoomRepository roomRepository, ILocalsService localsService)
        {
            _logger = logger;
            this.roomRepository = roomRepository;
            this.localsService = localsService;
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
        public object GetItems(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(TreeViewPlainData.Items, loadOptions);
        }

        [HttpGet]
        public IActionResult GetRoom(int id)
        {
            return Json(roomRepository.GetRoomByID(id));
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int key)
        {
            roomRepository.DeleteRoom(key);
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertRoom(RomRoom newRoom)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState
                  .SelectMany(modelState => modelState.Value.Errors)
                  .Select(err => err.ErrorMessage)
                  .ToList();

                return BadRequest(messages);
            }

            roomRepository.InsertRoom(newRoom);
            return Ok();
        }

        [HttpPut]
        public IActionResult SetRoom(RomRoom changedRoom)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState
                  .SelectMany(modelState => modelState.Value.Errors)
                  .Select(err => err.ErrorMessage)
                  .ToList();

                return BadRequest(messages);
            }

            roomRepository.UpdateRoom(changedRoom);
            return Ok();
        }

        [HttpGet]
        public object GetRooms(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(roomRepository.GetRooms(), loadOptions);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
