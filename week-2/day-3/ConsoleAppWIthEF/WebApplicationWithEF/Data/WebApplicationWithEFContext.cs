using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationWithEF.Models;

namespace WebApplicationWithEF.Data
{
    public class WebApplicationWithEFContext : DbContext
    {
        public WebApplicationWithEFContext (DbContextOptions<WebApplicationWithEFContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationWithEF.Models.Product> Product { get; set; } = default!;
    }
}
