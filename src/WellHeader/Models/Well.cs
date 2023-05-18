namespace WellHeader.Models
{
    public class Well
    {
        public int WellId { get; set; }
        public string WellName { get; set; } = string.Empty;
        public int FieldId { get; set; }
        //public DateOnly? SpudDate { get; set; } //added just to make Jeff Happy
        public string? APINumber { get; set; } = string.Empty;
        public string? API10 => APINumber!.Substring(0, 9);
        public double? Lat { get; set; }
        public double? Long { get; set; }
    }
}