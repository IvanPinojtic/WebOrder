using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebOrder.DAL.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; } = false;
        public double Price { get; set; }
        [ForeignKey("Meal")]
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
    }
}