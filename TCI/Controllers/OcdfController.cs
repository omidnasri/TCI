using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCI.Operation.Fiber.Interface;

namespace TCI.Controllers
{
    public partial class OcdfController : Controller
    {
        private readonly IOcdfOperation _ocdfOperation;
        public OcdfController(IOcdfOperation ocdfOperation)
        {
            _ocdfOperation = ocdfOperation;
        }

        public virtual ActionResult Index(int ocdfRoomId)
        {
            var ocdfs = _ocdfOperation.GetByOcdfRoomId(ocdfRoomId);
            return PartialView(ocdfs);
        }

        public virtual ActionResult Details(int ocdfId)
        {
            var ocdf = _ocdfOperation.GetDetails(ocdfId);
            return PartialView(ocdf);
        }
    }
}