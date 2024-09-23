using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class WishList
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WishListId { get; set; }
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }

    [Required]
    [ForeignKey("Item")]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }
}