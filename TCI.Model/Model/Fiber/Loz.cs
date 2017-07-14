using System.Collections;
using System.Collections.Generic;

namespace TCI.Model
{
    public class Loz : BaseModel
    {
        public int LozId { get; set; }
        public int Number { get; set; }
        public IList<CoreGroup> CoreGroups { get; set; }
    }
}
