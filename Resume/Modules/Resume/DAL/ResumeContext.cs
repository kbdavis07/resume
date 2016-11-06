namespace Modules.Resume.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using global::Resume.Models;
    using static global::Resume.Models.ResumeObject;

    public class ResumeContext : DbContext
    {
        // Your context has been configured to use a 'Resume' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Resume.Modules.Resume.DAL.Resume' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Resume' 
        // connection string in the application configuration file.
        public ResumeContext()
            : base("name=Resume")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<ResumeObject> Resumes { get; set; }
         public virtual DbSet<Basic> Basics { get; set; }
         public virtual DbSet<Location> Locations { get; set; }
         public virtual DbSet<Profile> Profiles { get; set; }
         public virtual DbSet<Work> Works { get; set; }
         public virtual DbSet<Volunteer> Volunteers { get; set; }
         public virtual DbSet<Education> Educations { get; set; }
         public virtual DbSet<Award> Awards { get; set; }

         public virtual DbSet<Publication> Publications { get; set; }
         public virtual DbSet<Skill> Skills { get; set; }
         public virtual DbSet<Language> Languages { get; set; }
         public virtual DbSet<Interest> Interests { get; set; }
         public virtual DbSet<Reference> References { get; set; }
         


    }

    
}