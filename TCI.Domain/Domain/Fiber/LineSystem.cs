using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("LineSystem", Schema = "fiber")]
    public class LineSystem : BaseEntity
    {
        public int LineSystemId { get; set; }
        [Required, ForeignKey("Ocdf")]
        public int OcdfId { get; set; }
        public Ocdf Ocdf { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<LineSystemItem> LineSystemItems { get; set; }
    }
}
