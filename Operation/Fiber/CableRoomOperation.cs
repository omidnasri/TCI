using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.DomainService.Fiber.Interface;
using TCI.Mapper.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class CableRoomOperation : BaseOperation<Domain.CableRoom, Model.CableRoom>, ICableRoomOperation
    {
        public CableRoomOperation(ICableRoomService baseService)
            : base(baseService)
        {
            (new CableRoomMapper()).Initialize();
        }

        public List<Model.CableRoom> GetByStation(int stationId)
        {
            return BaseService.GetAll(x => x.StationId == stationId).ProjectTo<Model.CableRoom>().ToList();
        }
    }
}
