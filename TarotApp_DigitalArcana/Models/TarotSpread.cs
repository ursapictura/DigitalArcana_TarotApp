using Npgsql;

namespace TarotApp.Models
{
    public class TarotSpread
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Array CardPositions { get; set; }
    }
}