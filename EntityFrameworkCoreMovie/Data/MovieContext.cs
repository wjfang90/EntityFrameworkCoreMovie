using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreMovie.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
		//“工具”>“NuGet 包管理器”>“包管理器控制台”
		//Add-Migration InitialCreate
		//Update-Database
        }

        public DbSet<EntityFrameworkCoreMovie.Models.Movie> Movie { get; set; }
    }
}
