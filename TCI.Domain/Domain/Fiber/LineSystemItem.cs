using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("LineSystemItem",Schema = "fiber")]
    public class LineSystemItem:BaseEntity
    {
        public int LineSystemItemId { get; set; }
        [Required,ForeignKey("LineSystem")]
        public int LineSystemId { get; set; }
        public LineSystem LineSystem { get; set; }
    }
}
