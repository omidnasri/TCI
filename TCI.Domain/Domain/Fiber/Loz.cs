using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Loz", Schema = "fiber")]
    public class Loz : BaseEntity
    {
        [Key]
        public int LozId { get; set; }
        [Required, ForeignKey("Cable")]
        public int CableId { get; set; }
        public Cable Cable { get; set; }
        public int Number { get; set; }

        public ICollection<Core> Cores { get; set; }
    }
}
