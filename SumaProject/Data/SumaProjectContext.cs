using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SumaProject.Models;

namespace SumaProject.Data
{
    public class SumaProjectContext : DbContext
    {
        public SumaProjectContext (DbContextOptions<SumaProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SumaProject.Models.User> User { get; set; } = default!;
    }
}
