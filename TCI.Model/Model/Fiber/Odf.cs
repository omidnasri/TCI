using System.Collections;
using System.Collections.Generic;

namespace TCI.Model
{
    public class Odf : BaseModel
    {
        public int OdfId { get; set; }
        public string Name { get; set; }

        public IList<OdfItemGroup> OdfItemGroups { get; set; }
    }
}
