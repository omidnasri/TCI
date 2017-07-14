using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.DomainService.Fiber.Interface;
using TCI.Mapper.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class CableOperation : BaseOperation<Domain.Cable, Model.Cable>, ICableOperation
    {
        public CableOperation(ICableService baseService)
            : base(baseService)
        {
            (new CableMapper()).Initialize();
        }

        public List<Model.Cable> GetStationCable(int stationId)
        {
            return AutoMapper.Mapper.Map<List<Model.Cable>>(BaseService.GetAll(x => x.FromStationId == stationId || x.ToStationId == stationId).ToList());
        }
    }
}
