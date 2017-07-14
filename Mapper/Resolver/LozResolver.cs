using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace TCI.Mapper.Resolver
{
    public class LozResolver : ValueResolver<Domain.Loz, List<Model.CoreGroup>>
    {
        protected override List<Model.CoreGroup> ResolveCore(Domain.Loz source)
        {
            if (source == null) return null;
            var result = new List<Model.CoreGroup>();
            Model.CoreGroup coreGroup = null;
            foreach (var core in source.Cores.OrderBy(x => x.CoreId).ToList())
            {
                if (coreGroup == null || coreGroup.SecondCore != null)
                {
                    coreGroup = new Model.CoreGroup();
                    result.Add(coreGroup);
                    coreGroup.FirstCore = AutoMapper.Mapper.Map<Model.Core>(core);
                }
                else
                {
                    coreGroup.SecondCore = AutoMapper.Mapper.Map<Model.Core>(core);
                }
            }
            return result;
        }
    }
}
