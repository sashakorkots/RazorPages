using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer CustomerOfDish { get; set; }
        
    }
}