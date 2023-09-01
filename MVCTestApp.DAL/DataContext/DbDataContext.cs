using Microsoft.EntityFrameworkCore;
using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.DAL.DataContext
{
    public class DbDataContext : DbContext
    {
        public DbDataContext(DbContextOptions<DbDataContext> options) : base(options) { }

        public DbSet<Login> Login { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Supplier> Supplier { get; set; }
    }
}
