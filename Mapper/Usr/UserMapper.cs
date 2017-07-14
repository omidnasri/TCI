using TCI.Domain;

namespace TCI.Mapper.Usr
{
    public class UserMapper : BaseMapper<Domain.User, Model.User>
    {
        public override void Initialize()
        {
            base.Initialize();
            EntityToModelMapper
                .ForMember(s => s.Name, d => d.MapFrom(x => (x.Person as RealPerson).Name))
                .ForMember(s => s.Family, d => d.MapFrom(x => (x.Person as RealPerson).Family));
        }
    }
}
