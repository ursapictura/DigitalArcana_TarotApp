using TarotApp.Models;

namespace TarotApp_DigitalArcana.Data
{
    public class SuitData
    {
        public List<TarotSuit> TartoSuits = new()
        {
            // -------- CUPS --------
            new() {Id = 1, Name = "Cups", Season = "Spring", Timeframe = "Moderate to slow moving: weeks to months", Description = "The suit of Cups represents emotions, intuition, and relationships. It deals with matters of the heart, feelings, love, and connections with others. Cups often indicate personal development on an emotional or relational level."},

            // -------- SWORDS --------

            new() {Id = 2, Name = "Swords", Season = "Winter", Timeframe = "Quick moving: hours to days", Description = "The suit of Swords symbolizes the mind, intellect, communication, and conflict. It reflects our thoughts, decisions, and challenges. Swords represent struggles, but also the triumph of truth and clarity."},

            // -------- WANDS --------

            new() {Id = 3, Name = "Wands", Season = "Summer", Timeframe = "Moderately fast moving: days to weeks", Description = "The suit of Wands represents action, ambition, and passion. It focuses on personal growth, creativity, and the pursuit of goals. Wands are about taking action, setting intentions, and pursuing one's passions."},

            // -------- PENTACLES --------

            new() {Id = 4, Name = "Pentacles", Season = "Autumn", Timeframe = "slow moving: months to years.", Description = "The suit of Pentacles deals with the material world, career, and finances. It is concerned with practical matters, such as work, money, health, and security. Pentacles represent growth in the physical realm and tangible success."}
        };
    }
}
