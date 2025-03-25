using System.Xml.Linq;
using TarotApp.Models;

namespace TarotApp.Data
{
	public class TarotCardData
	{
		public static List<TarotCard> TaroctCards = new()
		{
			new() {Id = 1, Name = "The Fool", CardNumber = 0, Meaning = "Represents new beginnings, unlimited potential, spontaneity, and taking a leap of faith. Can also warn against carelessness or naivety.", MajorArcana = true},
		    new() {Id = 2, Name = "The Magician", CardNumber = 1, Meaning = "Symbolizes manifestation, resourcefulness, creativity, and willpower. Encourages using all available tools to achieve goals.", MajorArcana = true},
		    new() {Id = 3, Name = "The High Priestess", CardNumber = 2, Meaning = "Represents intuition, mystery, and the subconscious mind. Suggests listening to inner guidance and uncovering hidden truths.", MajorArcana = true},
		    new() {Id = 4, Name = "The Empress", CardNumber = 3, Meaning = "Signifies abundance, femininity, nature, and creation. Represents nurturing energy and creative projects coming to fruition.", MajorArcana = true},
		    new() {Id = 5, Name = "The Emperor", CardNumber = 4, Meaning = "Embodies authority, structure, stability, and control. Encourages discipline and logical thinking to create a solid foundation.", MajorArcana = true},
		    new() {Id = 6, Name = "The Hierophant", CardNumber = 5, Meaning = "Represents tradition, spirituality, and conformity. Often signifies guidance through established structures, teachings, or religious practices.", MajorArcana = true},
		    new() {Id = 7, Name = "The Lovers", CardNumber = 6, Meaning = "Symbolizes love, harmony, and partnerships. Also represents choices and the need to align values with decisions.", MajorArcana = true},
		    new() {Id = 8, Name = "The Chariot", CardNumber = 7, Meaning = "Represents determination, willpower, and victory through control. Encourages overcoming obstacles and staying focused on goals.", MajorArcana = true},
		    new() {Id = 9, Name = "Strength", CardNumber = 8, Meaning = "Embodies inner courage, patience, and compassion. Suggests overcoming challenges through gentle strength rather than force.", MajorArcana = true},
		    new() {Id = 10, Name = "The Hermit", CardNumber = 9, Meaning = "Represents introspection, solitude, and searching for inner truth. Suggests taking time for self-reflection and spiritual enlightenment.", MajorArcana = true},
		    new() {Id = 11, Name = "Wheel of Fortune", CardNumber = 10, Meaning = "Represents cycles, luck, and destiny. Encourages embracing changes and trusting the flow of life.", MajorArcana = true},
		    new() {Id = 12, Name = "Justice", CardNumber = 11, Meaning = "Symbolizes fairness, truth, and accountability. Highlights the importance of ethical decision-making and facing consequences.", MajorArcana = true},
		    new() {Id = 13, Name = "The Hanged Man", CardNumber = 12, Meaning = "Represents letting go, surrender, and gaining new perspectives. Encourages patience and seeing things from a different angle.", MajorArcana = true},
		    new() {Id = 14, Name = "Death", CardNumber = 13, Meaning = "Signifies transformation, endings, and new beginnings. Encourages embracing change and letting go of what no longer serves.", MajorArcana = true},
		    new() {Id = 15, Name = "Temperance", CardNumber = 14, Meaning = "Represents balance, moderation, and harmony. Encourages blending opposing forces and finding a middle ground.", MajorArcana = true},
		    new() {Id = 16, Name = "The Devil", CardNumber = 15, Meaning = "Symbolizes bondage, addiction, and materialism. Highlights the need to break free from limiting beliefs or toxic attachments.", MajorArcana = true},
		    new() {Id = 17, Name = "The Tower", CardNumber = 16, Meaning = "Represents sudden upheaval, destruction, and revelation. Often signifies necessary change to rebuild a stronger foundation.", MajorArcana = true},
		    new() {Id = 18, Name = "The Star", CardNumber = 17, Meaning = "Signifies hope, inspiration, and renewal. Encourages faith in the future and the pursuit of dreams.", MajorArcana = true},
		    new() {Id = 19, Name = "The Moon", CardNumber = 18, Meaning = "Represents illusion, fear, and intuition. Encourages exploring subconscious fears and trusting instincts in uncertain situations.", MajorArcana = true},
		    new() {Id = 20, Name = "The Sun", CardNumber = 19, Meaning = "Symbolizes joy, success, and vitality. Highlights positive outcomes, clarity, and personal fulfillment.", MajorArcana = true},
		    new() {Id = 21, Name = "Judgment", CardNumber = 20, Meaning = "Represents rebirth, inner calling, and absolution. Encourages self-evaluation and making amends.", MajorArcana = true},
		    new() {Id = 22, Name = "The World", CardNumber = 21, Meaning = "Signifies completion, accomplishment, and integration. Represents achieving goals and celebrating success.", MajorArcana = true},
		};
	}
}