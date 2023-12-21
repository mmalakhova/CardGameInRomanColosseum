using System.ComponentModel.DataAnnotations.Schema;

namespace CardGameInRomanColosseumDI.Entity;

[Table("experiment")]
public class ExperimentEntity : BaseEntity
{
   public string Deck { get; set; }
}