using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebOrder.DAL.Models
{
    public enum MealType
    {
        Grill = 0,
        Soup = 1,
        Wok = 2,
        GlutenFree = 4,
        Italian = 8,
        Chinese = 16,
        Burger = 32,
        Kebab = 64,
        Sandwich = 128
    }
}
