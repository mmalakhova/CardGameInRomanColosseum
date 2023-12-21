namespace CardGameInRomanColiseum;

public class Card
{
   public CardColor Color { get; }

   public Card(CardColor color)
   {
      Color = color;
   }
   
   public bool CompareCards(Card anotherCard)
   {
      return Color.CompareTo(anotherCard.Color) == 0;
   }
   
   public enum CardColor
   {
      Red,
      Black
   }
}