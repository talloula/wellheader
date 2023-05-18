using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellHeader.Entities
{
    public class Well
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WellID { get; set; }
        public string WellName { get; set; } = string.Empty;
        public int FieldID { get; set; }
        //public DateOnly? SpudDate { get; set; } //added just to make Jeff Happy
        public string? APINumber { get; set; } = string.Empty;
        public string? API10 => APINumber!.Substring(0,10);
        public double? Lat { get; set; }
        public double? Long { get; set; }
    }
}