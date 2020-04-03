using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Infra.Data.Context
{
    public class InfraDataContext : DbContext
    {
        public InfraDataContext(DbContextOptions<InfraDataContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);
        }
    }
}
