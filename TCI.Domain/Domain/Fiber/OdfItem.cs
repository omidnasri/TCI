using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("OdfItem", Schema = "fiber")]
    public class OdfItem : BaseEntity
    {
        [Key]
        public int OdfItemId { get; set; }
        [Required, ForeignKey("Odf")]
        public int OdfId { get; set; }
        public Odf Odf { get; set; }
        public int Number { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
