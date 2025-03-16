using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_LINQ_Project.Models
{
    internal class TaskMangerDB:DbContext
    {
        public DbSet<User> Users { get; set; }  
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-NVQN1P3;Database=TaskManager;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .Property(t => t.Priority)
                .HasDefaultValue("Low");

            
            modelBuilder.Entity<TaskItem>()
                .ToTable(t => t.HasCheckConstraint("CHK_TaskItem_Priority", "Priority IN ('Low', 'Medium', 'High')"));
        }

    }

}
