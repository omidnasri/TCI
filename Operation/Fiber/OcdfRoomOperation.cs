using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.DomainService.Fiber.Interface;
using TCI.Mapper.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class OcdfRoomOperation : BaseOperation<Domain.OcdfRoom, Model.OcdfRoom>, IOcdfRoomOperation
    {
        public OcdfRoomOperation(IOcdfRoomService ocdfRoomService)
            : base(ocdfRoomService)
        {
            (new OcdfRoomMapper()).Initialize();
        }

        public List<Model.OcdfRoom> GetByStation(int stationId)
        {
            return BaseService.GetAll(x => x.StationId == stationId).ProjectTo<Model.OcdfRoom>().ToList();
        }

        public Model.OcdfRoom GetDetails(int ocdfRoomId)
        {
            return AutoMapper.Mapper.Map<Model.OcdfRoom>(BaseService.GetFirst(x => x.OcdfRoomId == ocdfRoomId));
        }
    }
}
