using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Data;
using Bigfoot.Models;
using Microsoft.Data.SqlClient;

namespace Bigfoot.Pages.Team
{
    public class IndexModel : PageModel
    {
        private readonly Bigfoot.Data.BigfootContext _context;

        public IndexModel(Bigfoot.Data.BigfootContext context)
        {
            _context = context;
        }
        public IList<Sightings> Sightings { get;set; } = default!;
        public string StateSort { get; set; }
        public string YearSort { get; set; }
        public string MonthSort { get; set; }
        public string ClassSort { get; set; }


        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public string CurrentFilter { get; set; }





        public async Task OnGetAsync(string sortOrder, string filterString)
        {
            
            StateSort = String.IsNullOrEmpty(sortOrder) ? "State_desc" : "";
            MonthSort = sortOrder == "Month" ? "Month_desc" : "Month";
            ClassSort = sortOrder == "Class" ? "Class_desc" : "Class";
            YearSort = sortOrder == "Year" ? "Year_desc" : "Year";
            if (_context.Sightings != null)
            {
                Sightings = await _context.Sightings.ToListAsync();
            }
            IQueryable<Sightings> title = from i in _context.Sightings
                        select i;

            switch (sortOrder)
            {
                case "State_desc":
                    title = title.OrderByDescending(i => i.State);
                    break;
                case "Month":
                    title = title.OrderBy(i => i.Month);
                    break;
                case "Month_desc":
                    title = title.OrderByDescending(i => i.Month);
                    break;
                case "Class":
                    title = title.OrderBy(i => i.Class);
                    break;
                case "Class_desc":
                    title = title.OrderByDescending(i => i.Class);
                    break;
                case "Year":
                    title = title.OrderBy(i => i.Year);
                    break;
                case "Year_desc":
                    title = title.OrderByDescending(i => i.Year);
                    break;
                default:
                    title = title.OrderBy(i => i.State);
                    break;
            }
         

            if (!string.IsNullOrEmpty(SearchString))
            {
                title = title.Where(e => e.State.Contains(SearchString));
            }

            CurrentFilter = filterString;

            if (!String.IsNullOrEmpty(filterString))
            {
                title = title.Where(s => s.Class.Contains(filterString)
                || s.Month.Contains(filterString)
                || s.Year.Contains(filterString));

            }
            

            Sightings = await title.ToListAsync();
            
        }


    }
}
   /*
            if (sortOrder == "State_desc")
            {
                title = title.OrderByDescending(m => m.State);
            }
            else
            {
                title = title.OrderBy(m => m.State);
            }

            if (sortOrder == "Year_desc")
            {
                title = title.OrderByDescending(m => m.Year);
            }
            else
            {
                title = title.OrderBy(m => m.Year);
            }*/