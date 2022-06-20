using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GoTokeshopWEB.Data;
using GoTokeshopWEB.Model;

namespace GoTokeshopWEB.Pages.CategoryTemp
{
    public class IndexModel : PageModel
    {
        private readonly GoTokeshopWEB.Data.ApplicationDbContext _context;

        public IndexModel(GoTokeshopWEB.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
