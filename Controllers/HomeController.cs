using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.NETCore.Demos.Models.SampleData;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s4h.Models;
using s4h.Repositories;
using s4h.Services;
using System;
using System.Diagnostics;

namespace s4h.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRoomRepository roomRepository;
        private IValidator<RomRoom> roomValidator;

        public HomeController(ILogger<HomeController> logger, IRoomRepository roomRepository, IValidator<RomRoom> roomValidator)
        {
            _logger = logger;
            this.roomRepository = roomRepository;
            this.roomValidator = roomValidator;
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
            ValidationResult result = roomValidator.Validate(newRoom);

            if (!result.IsValid)
                return BadRequest(result);

            roomRepository.InsertRoom(newRoom);
            return Ok();
        }

        [HttpPut]
        public IActionResult SetRoom(RomRoom changedRoom)
        {
            ValidationResult result = roomValidator.Validate(changedRoom);

            if (!result.IsValid)
                return BadRequest(result);
 
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
