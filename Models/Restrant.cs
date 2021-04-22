using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Restrant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {Address} {PhoneNumber}";
        }
    }
}