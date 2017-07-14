using System.Collections.Generic;

namespace TCI.Operation.Fiber.Interface
{
    public interface IOcdfOperation : IBaseOperation<Domain.Ocdf, Model.Ocdf>
    {
        List<Model.Ocdf> GetByOcdfRoomId(int ocdfRoomId);
        Model.Ocdf GetDetails(int ocdfId);
    }
}
