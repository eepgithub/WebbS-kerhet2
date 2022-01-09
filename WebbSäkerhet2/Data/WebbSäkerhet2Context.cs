using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbSäkerhet2.Models;

namespace WebbSäkerhet2.Data
{
    public class WebbSäkerhet2Context : DbContext
    {
        public WebbSäkerhet2Context (DbContextOptions<WebbSäkerhet2Context> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
    }
}
