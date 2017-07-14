using System.Collections.Generic;

namespace TCI.Operation.Fiber.Interface
{
    public interface ICableRoomOperation : IBaseOperation<Domain.CableRoom, Model.CableRoom>
    {
        List<Model.CableRoom> GetByStation(int stationId);
    }
}
