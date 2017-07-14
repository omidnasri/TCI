using System.Collections;
using System.Collections.Generic;

namespace TCI.Model
{
    public class LineSystem : BaseModel
    {
        public int LineSystemId { get; set; }

        public string Name { get; set; }

        public IList<LineSystemItem> LineSystemItems { get; set; }
    }
}
