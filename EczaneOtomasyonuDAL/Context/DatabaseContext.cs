using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext () : base("ConnectionString")
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Hasta>()
        //        .HasIndex(u => u.HastaTc)
        //        .IsUnique();
        //    //TODO: relationship
        //}
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Ilac> Ilaclar { get; set; }
        public virtual DbSet<siparisHeader> siparisHeaders { get; set; }
        public virtual DbSet<siparisItem> siparisItems { get; set; }

    }
}
