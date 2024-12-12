using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;
using TaskManager_V01.Models;
using Task = TaskManager_V01.Models.Task;

namespace TaskManager_V01.DataAccess
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<TaskAssignee> TaskAssignees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>()
                .Property(u => u.AccountID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserAccount>()
                .HasKey(u => u.AccountID);

            modelBuilder.Entity<UserAccount>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Project>()
                .Property(u => u.ProjectId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Project>()
                .HasKey(u => u.ProjectId);

            modelBuilder.Entity<Project>()
                .HasIndex(u => u.Tittle)
                .IsUnique();

            modelBuilder.Entity<Project>()
                .HasOne(e => e.Owner)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.OwnerAccountID)
                .OnDelete(DeleteBehavior.NoAction) 
                .IsRequired();

            modelBuilder.Entity<Task>()
                .HasIndex(u => u.TaskId)
                .IsUnique();

            modelBuilder.Entity<Task>()
                .HasOne(e => e.Project)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.ProjectID)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<Task>()
                .HasOne(e => e.Reporter)
                .WithMany()
                .HasForeignKey(e => e.ReporterAccountID)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Media>()
                .HasIndex(u => u.MediaId)
                .IsUnique();

            modelBuilder.Entity<Media>()
                .HasOne(e => e.Task)
                .WithMany(e => e.Medias)
                .HasForeignKey(e => e.TaskID);

            modelBuilder.Entity<Comment>()
                .HasIndex(u => u.CommentId)
                .IsUnique();

            modelBuilder.Entity<Comment>()
                .HasOne(e => e.Task)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TaskAssignee>()
                .HasKey(tu => new { tu.TaskId, tu.UserAccountID }); 

            modelBuilder.Entity<TaskAssignee>()
                .HasOne(tu => tu.Task)
                .WithMany()
                .HasForeignKey(tu => tu.TaskId);

            modelBuilder.Entity<TaskAssignee>()
                .HasOne(tu => tu.UserAccount)
                .WithMany()
                .HasForeignKey(tu => tu.UserAccountID);


        }
    }
}
