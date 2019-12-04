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
    public class DetailsModel : PageModel
    {
        private readonly ElectroniTrading.Data.ProductContext _context;

        public DetailsModel(ElectroniTrading.Data.ProductContext context)
        {
            _context = context;
        }

        public product product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
