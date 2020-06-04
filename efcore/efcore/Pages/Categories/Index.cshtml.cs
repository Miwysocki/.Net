using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using efcore.Data;
using efcore.Models;

namespace efcore.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly efcore.Data.Context _context;

        public IndexModel(efcore.Data.Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }
        public IList<Product> ProductList { get; set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
            ProductList =  await _context.Product.ToListAsync();
        }
    }
}
