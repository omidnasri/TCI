using TCI.Mapper.Resolver;

namespace TCI.Mapper.Fiber
{
    public class LozMapper : BaseMapper<Domain.Loz, Model.Loz>
    {
        public override void Initialize()
        {
            base.Initialize();
            EntityToModelMapper
                .ForMember(d => d.CoreGroups, s => s.ResolveUsing<LozResolver>().FromMember(x => x));
        }
    }
}
