using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bigfoot.Data;
using Bigfoot.Models;

namespace Bigfoot.Pages.Team
{
    public class CreateModel : PageModel
    {
        private readonly Bigfoot.Data.BigfootContext _context;

        public CreateModel(Bigfoot.Data.BigfootContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sightings Sightings { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sightings.Add(Sightings);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
