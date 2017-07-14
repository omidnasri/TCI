using TCI.Mapper.Resolver;

namespace TCI.Mapper.Fiber
{
    public class OdfMapper : BaseMapper<Domain.Odf, Model.Odf>
    {
        public override void Initialize()
        {
            base.Initialize();
            EntityToModelMapper.ForMember(d => d.OdfItemGroups,
                s => s.ResolveUsing<OdfItemGroupResolver>().FromMember(x => x));
        }
    }
}
