
namespace CardGameInRomanColosseum.Cards;

public class Card
{
   private CardColor Color { get; }
   private String Type { get; }

   public Card(CardColor color, string type)
   {
      Color = color;
      Type = type;
   }
}