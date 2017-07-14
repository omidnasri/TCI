using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Core", Schema = "fiber")]
    public class Core : BaseEntity
    {
        [Key]
        public int CoreId { get; set; }

        [Required, ForeignKey("Loz")]
        public int LozId { get; set; }
        public Loz Loz { get; set; }
        public int Number { get; set; }
    }
}
