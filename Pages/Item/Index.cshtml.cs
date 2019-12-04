using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ElectroniTrading.Data;
using ElectroniTrading.Models;

namespace ElectroniTrading.Pages_Item
{
    public class IndexModel : PageModel
    {
        private readonly ElectroniTrading.Data.ProductContext _context;

        public IndexModel(ElectroniTrading.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<product> product { get;set; }

        public async Task OnGetAsync()
        {
            product = await _context.Products.ToListAsync();
        }
    }
}
