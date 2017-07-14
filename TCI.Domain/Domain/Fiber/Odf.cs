using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Odf", Schema = "fiber")]
    public class Odf : BaseEntity
    {
        [Key]
        public int OdfId { get; set; }

        [Required, ForeignKey("Ocdf")]
        public int OcdfId { get; set; }
        public Ocdf Ocdf { get; set; }
        public int ItemCount { get; set; }
        public int StartNumber { get; set; }
        public string Name { get; set; }

        public ICollection<OdfItem> OdfItems { get; set; }
    }
}
