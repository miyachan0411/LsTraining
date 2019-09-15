using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LsTools
{
    class DBModel : DbContext
    {
        public DbSet<NEWS> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:dev-l011.database.windows.net,1433;Initial Catalog=DEV_L011;Persist Security Info=False;User ID=ls;Password=B19850411@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
