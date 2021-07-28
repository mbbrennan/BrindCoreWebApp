using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrindCoreWebApp.Models;

namespace BrindCoreWebApp
{
    public class IndexModel : PageModel
    {
        private readonly BrindCoreWebApp.Models.WebAppContext _context;

        public IndexModel(BrindCoreWebApp.Models.WebAppContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Teams.ToListAsync();
        }
    }
}
