using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.DomainService.Fiber.Interface;
using TCI.Mapper.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class OcdfOperation : BaseOperation<Domain.Ocdf, Model.Ocdf>, IOcdfOperation
    {
        public OcdfOperation(IOcdfService baseService)
            : base(baseService)
        {
            (new OcdfMapper()).Initialize();
            (new SectionMapper()).Initialize();
            (new CassetteMapper()).Initialize();
            (new OdfMapper()).Initialize();
            (new OdfItemMapper()).Initialize();
            (new LineSystemMapper()).Initialize();
            (new LineSystemItemMapper()).Initialize();
            (new CableMapper()).Initialize();
            (new LozMapper()).Initialize();
            (new CoreMapper()).Initialize();
        }

        public List<Model.Ocdf> GetByOcdfRoomId(int ocdfRoomId)
        {
            return AutoMapper.Mapper.Map<List<Model.Ocdf>>(BaseService.GetAll(x => x.OcdfRoomId == ocdfRoomId).ToList());
        }

        public Model.Ocdf GetDetails(int ocdfId)
        {
            return AutoMapper.Mapper.Map<Model.Ocdf>(BaseService.GetFirst(x => x.OcdfId == ocdfId,
                new List<string>
                {
                    "Sections",
                    "Sections.Cassettes",
                    "Odfs",
                    "Odfs.OdfItems",
                    "LineSystems",
                    "LineSystems.LineSystemItems",
                    "FromCables",
                    "ToCables",
                    "FromCables.Lozes",
                    "ToCables.Lozes",
                    "FromCables.Lozes.Cores",
                    "ToCables.Lozes.Cores"
                }));
        }
    }
}
