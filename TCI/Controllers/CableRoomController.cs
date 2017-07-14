using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCI.Operation.Fiber;

namespace TCI.Controllers
{
    public partial class CableRoomController : Controller
    {
        private readonly CableRoomOperation _cableRoomOperation;
        public CableRoomController(CableRoomOperation cableRoomOperation)
        {
            _cableRoomOperation = cableRoomOperation;
        }

        public virtual ActionResult Index(int stationId)
        {
            var cableRoooms = _cableRoomOperation.GetByStation(stationId);
            return PartialView(cableRoooms);
        }
    }
}