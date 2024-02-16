using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_learn.Data;
using ASP_learn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_learn.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASP_learn.Data.ApplicationContext _context;

        public IndexModel(ASP_learn.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var movies = await _context.Movies.ToListAsync();

            if (!string.IsNullOrEmpty(SearchString)) 
            {
                movies = movies.Where(m => m.Title.Contains(SearchString)).ToList(); ;
            }

            Movie = movies;
        }
    }
}
