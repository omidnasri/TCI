using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Cassette", Schema = "fiber")]
    public class Cassette : BaseEntity
    {
        [Key]
        public int CassetteId { get; set; }

        [Required, ForeignKey("Section")]
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public string Name { get; set; }

    }
}
