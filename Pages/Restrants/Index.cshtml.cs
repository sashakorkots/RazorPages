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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public IndexModel(RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Restrant> Restrant { get;set; }

        public async Task OnGetAsync()
        {
            Restrant = await _context.Restrant.ToListAsync();
        }
    }
}
