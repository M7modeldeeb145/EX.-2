using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
                ("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .Property(e => e.Name).HasMaxLength(100);
            modelBuilder.Entity<Student>()
                .Property(e => e.Name).IsUnicode(true);
            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber).HasMaxLength(10);
            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber).IsUnicode(false);
            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber).IsRequired(false);
            //modelBuilder.Entity<Student>()
            //    .Property(e=>e.BirthDay).IsRequired(false);
            modelBuilder.Entity<Course>()
                .Property(e => e.Description).IsRequired(false);
            modelBuilder.Entity<Resource>()
                .Property(e => e.Name).HasMaxLength(50);
        }
    }
}
