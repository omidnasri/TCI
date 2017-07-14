using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCI.Operation.Fiber.Interface;

namespace TCI.Controllers
{
    public partial class StationController : Controller
    {
        private readonly IStationOperation _stationOperation;
        public StationController(IStationOperation stationOperation)
        {
            _stationOperation = stationOperation;
        }

        public virtual ActionResult Index()
        {
            var stations = _stationOperation.GetAll();
            return View(stations);
        }

        public virtual ActionResult Details(int stationId)
        {
            var operation = _stationOperation.GetDetails(stationId);
            return View(operation);
        }
    }
}