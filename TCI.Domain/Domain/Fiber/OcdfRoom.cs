using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("OcdfRoom", Schema = "fiber")]
    public class OcdfRoom : BaseEntity
    {
        [Key]
        public int OcdfRoomId { get; set; }

        [Required, ForeignKey("Station")]
        public int StationId { get; set; }
        public Station Station { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
