using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Section", Schema = "fiber")]
    public class Section : BaseEntity
    {
        [Key]
        public int SectionId { get; set; }
        [Required, ForeignKey("Ocdf")]
        public int OcdfId { get; set; }
        public Ocdf Ocdf { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Cassette> Cassettes { get; set; }
    }
}
