using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Models;
using Test_AdminPanel.Models.VM;

namespace Test_AdminPanel.Data
{
    public class Context:DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Station> stations { get; set; }
        public DbSet<Kassa> kassas { get; set; }


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
             .HasKey(p => new { p.UserID });

            modelBuilder.Entity<User>()
                .Property(p => p.UserName)
                .HasMaxLength(150)
                .HasColumnType("nvarchar");
                

            modelBuilder.Entity<User>()
                .Property(p => p.UserPassword)
                .HasMaxLength(150)
                .HasColumnType("nvarchar");

                modelBuilder.Entity<User>()
               .Property(p => p.UserCreateDate)
              .HasDefaultValueSql("getdate()")
               .IsRequired();


            //Stations 
            modelBuilder.Entity<Station>()
            .HasKey(p => new { p.StationID });

            modelBuilder.Entity<Station>()
                .Property(p => p.StationName)
                .HasMaxLength(150)
                .HasColumnType("nvarchar");

            //Kassa
            modelBuilder.Entity<Kassa>()
            .HasKey(p => new { p.KassaID });





        }
    }
}
