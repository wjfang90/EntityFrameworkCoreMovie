using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreMovie.Models;

namespace EntityFrameworkCoreMovie.Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly EntityFrameworkCoreMovie.Models.MovieContext _context;

        public IndexModel(EntityFrameworkCoreMovie.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
