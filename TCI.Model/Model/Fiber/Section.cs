using System.Collections;
using System.Collections.Generic;

namespace TCI.Model
{
    public class Section : BaseModel
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public IList<Cassette> Cassettes { get; set; }
    }
}
