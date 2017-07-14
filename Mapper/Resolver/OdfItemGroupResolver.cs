using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace TCI.Mapper.Resolver
{
    public class OdfItemGroupResolver : ValueResolver<Domain.Odf, List<Model.OdfItemGroup>>
    {
        protected override List<Model.OdfItemGroup> ResolveCore(Domain.Odf source)
        {
            if (source == null) return null;
            var result = new List<Model.OdfItemGroup>();
            Model.OdfItemGroup odfItemGroup = null;
            foreach (var odfItem in source.OdfItems.OrderBy(x => x.OdfItemId).ToList())
            {
                if (odfItemGroup == null || odfItemGroup.SecondOdfItem != null)
                {
                    odfItemGroup = new Model.OdfItemGroup();
                    result.Add(odfItemGroup);
                    odfItemGroup.FirstOdfItem = AutoMapper.Mapper.Map<Model.OdfItem>(odfItem);
                }
                else
                {
                    odfItemGroup.SecondOdfItem = AutoMapper.Mapper.Map<Model.OdfItem>(odfItem);
                }
            }
            return result;
        }
    }
}
