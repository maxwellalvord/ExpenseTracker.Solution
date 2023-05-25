using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker_Solution.Models
{
  public class Category
  {
    [Key]
    public int CategoryId { get; set; }
  }
}