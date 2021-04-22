using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class DishsOfOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order OrderOfList { get; set; }        
        public List<Dish> DishesOfOrder { get; set; }
    }
}