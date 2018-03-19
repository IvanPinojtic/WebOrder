using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOrder.DAL.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public MealType MealType { get; set; }
        public double MinimalOrder { get; set; }
        public double Rating { get; set; }
        public virtual ICollection<WorkDay> WorkDays { get; set; }
        public bool IsOpen { get; set; }
        public int AverageDeliveryTime { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
