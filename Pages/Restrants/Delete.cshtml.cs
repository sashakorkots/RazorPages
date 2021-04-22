using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages_Restrants
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public DeleteModel(RazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Restrant Restrant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restrant = await _context.Restrant.FirstOrDefaultAsync(m => m.Id == id);

            if (Restrant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restrant = await _context.Restrant.FindAsync(id);

            if (Restrant != null)
            {
                _context.Restrant.Remove(Restrant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
