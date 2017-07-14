using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCI.Model
{
    public class Station : BaseModel
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public Types.Station.StationType StationType { get; set; }

        public List<CableRoom> CableRooms { get; set; }
    }
}
