namespace FIT5032_Assessment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FIT5032_Assessment_Model : DbContext
    {
        public FIT5032_Assessment_Model()
            : base("name=FIT5032_Assessment_Model")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<CourseList> CourseLists { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<ModifyCours> ModifyCourses { get; set; }
        public virtual DbSet<ModifyTest> ModifyTests { get; set; }
        public virtual DbSet<ModifyUser> ModifyUsers { get; set; }
        public virtual DbSet<TestList> TestLists { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.ModifyTests)
                .WithRequired(e => e.Administrator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.ModifyUsers)
                .WithRequired(e => e.Administrator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.ModifyCourses)
                .WithRequired(e => e.Administrator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cours>()
                .HasMany(e => e.CourseLists)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cours>()
                .HasMany(e => e.ModifyCourses)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.ModifyTests)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.TestLists)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CourseLists)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ModifyUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TestLists)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
