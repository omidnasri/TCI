using TCI.Mapper.Resolver;

namespace TCI.Mapper.Fiber
{
    public class OcdfMapper : BaseMapper<Domain.Ocdf, Model.Ocdf>
    {
        public override void Initialize()
        {
            base.Initialize();
            EntityToModelMapper
                .ForMember(d => d.Cables, s => s.ResolveUsing<OcdfResolver>().FromMember(x => x));
        }
    }
}
