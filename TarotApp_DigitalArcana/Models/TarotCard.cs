namespace TarotApp.Models
{
    public class TarotCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SuitId { get; set; }
        public TarotSuit Suit { get; set; }
        public bool MajorArcana { get; set; }
        public int CardNumber { get; set; }
        public string ImagePath { get; set; }
        public string Meaning { get; set; }
        public string ReverseMeaning { get; set; }
    }
}