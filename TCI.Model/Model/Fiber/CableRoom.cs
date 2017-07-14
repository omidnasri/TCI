using System.ComponentModel.DataAnnotations;

namespace TCI.Model
{
    public class CableRoom : BaseModel
    {
        public int CableRoomId { get; set; }
        public string Name { get; set; }
    }
}
