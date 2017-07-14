using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("CableRoom", Schema = "fiber")]
    public class CableRoom : BaseEntity
    {
        [Key]
        public int CableRoomId { get; set; }

        [Required, ForeignKey("Station")]
        public int StationId { get; set; }
        public Station Station { get; set; }

        public string Name { get; set; }
    }
}
