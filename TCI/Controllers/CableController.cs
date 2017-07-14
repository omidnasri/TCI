using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCI.Operation.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Controllers
{
    public partial class CableController : Controller
    {
        private readonly ICableOperation _cableOperation;
        public CableController(ICableOperation cableOperation)
        {
            _cableOperation = cableOperation;
        }

        public virtual ActionResult StationFreeCable(int stationId)
        {
            var cables = _cableOperation.GetStationCable(stationId);
            return PartialView(cables);
        }
    }
}