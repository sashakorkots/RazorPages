using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages_DishsOfOrders
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public EditModel(RazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DishsOfOrder DishsOfOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DishsOfOrder = await _context.DishsOfOrder
                .Include(d => d.OrderOfList).FirstOrDefaultAsync(m => m.Id == id);

            if (DishsOfOrder == null)
            {
                return NotFound();
            }
           ViewData["OrderId"] = new SelectList(_context.Order, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DishsOfOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DishsOfOrderExists(DishsOfOrder.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DishsOfOrderExists(int id)
        {
            return _context.DishsOfOrder.Any(e => e.Id == id);
        }
    }
}
