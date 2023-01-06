using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Data;
using Bigfoot.Models;

namespace Bigfoot.Pages.Team
{
    public class DeleteModel : PageModel
    {
        private readonly Bigfoot.Data.BigfootContext _context;

        public DeleteModel(Bigfoot.Data.BigfootContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sightings Sightings { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sightings == null)
            {
                return NotFound();
            }

            var sightings = await _context.Sightings.FirstOrDefaultAsync(m => m.ID == id);

            if (sightings == null)
            {
                return NotFound();
            }
            else 
            {
                Sightings = sightings;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Sightings == null)
            {
                return NotFound();
            }
            var sightings = await _context.Sightings.FindAsync(id);

            if (sightings != null)
            {
                Sightings = sightings;
                _context.Sightings.Remove(Sightings);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
