
namespace CardGameInRomanColiseum.Cards;

public class Card
{
   public CardColor _color { get; }

   public Card(CardColor color)
   {
      _color = color;
   }
   
   public bool CompareCards(Card anotherCard)
   {
      return _color.CompareTo(anotherCard._color) == 0;
   }
   
   public enum CardColor
   {
      Red = 1,
      Black
   }
}