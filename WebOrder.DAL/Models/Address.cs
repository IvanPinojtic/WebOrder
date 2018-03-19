using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOrder.DAL.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string DoorName { get; set; }
        public string City { get; set; } = "Zagreb";
        public Area Area { get; set; }
        public string StreetNumber { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
