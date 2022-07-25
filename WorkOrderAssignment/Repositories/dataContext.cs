using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderAssignment.Repositories
{
    public class dataContext : DbContext
    {
        public dataContext() { }
        public dataContext(DbContextOptions options) : base(options) 
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {

        }
        public DbSet<WorkOrder> WO
        {
            get;set;
        }
        public DbSet<Technician> TC
        {
            get;set;
        }
    }
}
