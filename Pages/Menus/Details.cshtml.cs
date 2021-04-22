using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages_Menus
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public DetailsModel(RazorPagesContext context)
        {
            _context = context;
        }

        public Menu Menu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = await _context.Menu
                .Include(m => m.RestrantOfMenu).FirstOrDefaultAsync(m => m.Id == id);

            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
