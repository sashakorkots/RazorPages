using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages_Couriers
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public DetailsModel(RazorPagesContext context)
        {
            _context = context;
        }

        public Courier Courier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Courier = await _context.Courier.FirstOrDefaultAsync(m => m.Id == id);

            if (Courier == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
