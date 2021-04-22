using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages_Regions
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public IndexModel(RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Region> Region { get;set; }

        public void OnGet()
        {
            Region =  _context.Region
                .Include(r => r.RestrantOfMenu).ToList();
            Region =  _context.Region
                .Include(r => r.CouriersOfRestrant).ToList();
        }
    }
}
