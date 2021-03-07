using DataContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.DataContext
{
   public class EFDBContext :DbContext
    {
        public EFDBContext()
        {

        }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=Deb; initial catalog=Pers_ProjectDB;persist security info=True;user id=sa;password=abc123;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
