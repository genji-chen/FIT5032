﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assessment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class assessment_ModelContainer : DbContext
    {
        public assessment_ModelContainer()
            : base("name=assessment_ModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestList> TestLists { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseList> CourseLists { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<ModifyTest> ModifyTests { get; set; }
        public virtual DbSet<ModifyCourse> ModifyCourses { get; set; }
        public virtual DbSet<ModifyUser> ModifyUsers { get; set; }
    }
}
