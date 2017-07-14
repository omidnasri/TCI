using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class OcdfRoomService : BaseService<Domain.OcdfRoom>, IOcdfRoomService
    {
        public OcdfRoomService(IFiberUnitOfWork fiberUnitOfWork)
            : base(fiberUnitOfWork)
        {
        }
    }
}
