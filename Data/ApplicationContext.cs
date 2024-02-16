using ASP_learn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_learn.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        { 
        
        }

        
    }
}
