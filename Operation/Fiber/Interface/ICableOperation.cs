using System.Collections.Generic;

namespace TCI.Operation.Fiber.Interface
{
    public interface ICableOperation : IBaseOperation<Domain.Cable, Model.Cable>
    {
        List<Model.Cable> GetStationCable(int stationId);
    }
}