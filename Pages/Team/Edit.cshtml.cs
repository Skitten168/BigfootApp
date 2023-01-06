using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Data;
using Bigfoot.Models;

namespace Bigfoot.Pages.Team
{
    public class EditModel : PageModel
    {
        private readonly Bigfoot.Data.BigfootContext _context;

        public EditModel(Bigfoot.Data.BigfootContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sightings Sightings { get; set; } = default!;

        //[BindProperty]
        //public IFormFile Photo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sightings == null)
            {
                return NotFound();
            }

            var sightings =  await _context.Sightings.FirstOrDefaultAsync(m => m.ID == id);
            if (sightings == null)
            {
                return NotFound();
            }
            Sightings = sightings;
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

            _context.Attach(Sightings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SightingsExists(Sightings.ID))
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

        private bool SightingsExists(int id)
        {
          return _context.Sightings.Any(e => e.ID == id);
        }
    }
}
