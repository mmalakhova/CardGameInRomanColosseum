using System.ComponentModel.DataAnnotations;

namespace CardGameInRomanColosseumDI.Entity;

public abstract class BaseEntity
{
    [Key] 
    public Guid Id { get; set; }
}