using Microsoft.AspNetCore.Mvc;
using s4h.Repositories;
using s4h.Services;

namespace s4h.Controllers
{
    public class LocalsController : Controller
    {
        private ILocalsService localsService;

        public LocalsController(ILocalsService localsService)
        {
            this.localsService = localsService;
        }

        [HttpGet]
        public object GetLocals()
        {
            return Json(localsService.GetLocals());
        }

        [HttpGet]
        public object GetStandards(int localId)
        {
            return Json(localsService.GetLocalStandards(localId));
        }
    }
}
