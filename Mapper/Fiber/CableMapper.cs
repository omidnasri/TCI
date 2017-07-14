namespace TCI.Mapper.Fiber
{
    public class CableMapper : BaseMapper<Domain.Cable, Model.Cable>
    {
        public override void Initialize()
        {
            base.Initialize();
            EntityToModelMapper
                .ForMember(d => d.ExtendedLozCount, s => s.MapFrom(x => x.ExtendedLozCount ?? 0))
                .ForMember(d => d.ExtendedCoreCount, s => s.MapFrom(x => x.ExtendedCoreCount ?? 0));
        }
    }
}
