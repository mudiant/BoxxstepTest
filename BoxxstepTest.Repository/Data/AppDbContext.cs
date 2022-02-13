using BoxxstepTest.Repository.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BoxxstepTest.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        DbSet<Contact> Contact { get; set; }     

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Relation>().HasKey("ContactId", "ReportTo");

        //    base.OnModelCreating(modelBuilder);
        //}
    }   
}
