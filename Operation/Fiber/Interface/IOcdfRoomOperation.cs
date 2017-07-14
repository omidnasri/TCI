using System.Collections.Generic;

namespace TCI.Operation.Fiber.Interface
{
    public interface IOcdfRoomOperation : IBaseOperation<Domain.OcdfRoom, Model.OcdfRoom>
    {
        List<Model.OcdfRoom> GetByStation(int stationId);
        Model.OcdfRoom GetDetails(int ocdfRoomId);
    }
}
