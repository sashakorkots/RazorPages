using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Courier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}