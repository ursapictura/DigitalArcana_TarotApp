namespace TarotApp.Models
{
    public class Reading
    {
        public int Id { get; set; }
        public int SpreadId { get; set; }
        public TarotSpread ReadingSpread { get; set; }
        public string Uid { get; set; }
        public DateOnly Date { get; set; }
    }
}