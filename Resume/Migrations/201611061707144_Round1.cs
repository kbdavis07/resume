namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Round1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        date = c.String(),
                        awarder = c.String(),
                        summary = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.Basics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        label = c.String(),
                        picture = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        website = c.String(),
                        summary = c.String(nullable: false),
                        location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.location_Id)
                .Index(t => t.location_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        address = c.String(),
                        postalCode = c.String(),
                        city = c.String(),
                        countryCode = c.String(),
                        region = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        institution = c.String(),
                        area = c.String(),
                        studyType = c.String(),
                        startDate = c.String(),
                        endDate = c.String(),
                        gpa = c.String(),
                        ResumeObjectId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObjectId)
                .Index(t => t.ResumeObjectId);
            
            CreateTable(
                "dbo.Interests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        level = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        network = c.String(),
                        username = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        publisher = c.String(),
                        releaseDate = c.String(),
                        website = c.String(),
                        summary = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        reference = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.ResumeObjects",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Basic_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Basics", t => t.Basic_Id)
                .Index(t => t.Basic_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        level = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        organization = c.String(),
                        position = c.String(),
                        website = c.String(),
                        startDate = c.String(),
                        endDate = c.String(),
                        summary = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        company = c.String(),
                        position = c.String(),
                        website = c.String(),
                        startDate = c.String(),
                        endDate = c.String(),
                        summary = c.String(),
                        ResumeObject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeObjects", t => t.ResumeObject_Id)
                .Index(t => t.ResumeObject_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Volunteers", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Skills", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.References", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Publications", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Languages", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Interests", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Educations", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.ResumeObjects", "Basic_Id", "dbo.Basics");
            DropForeignKey("dbo.Awards", "ResumeObject_Id", "dbo.ResumeObjects");
            DropForeignKey("dbo.Basics", "location_Id", "dbo.Locations");
            DropIndex("dbo.Works", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Volunteers", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Skills", new[] { "ResumeObject_Id" });
            DropIndex("dbo.ResumeObjects", new[] { "Basic_Id" });
            DropIndex("dbo.References", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Publications", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Languages", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Interests", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Educations", new[] { "ResumeObject_Id" });
            DropIndex("dbo.Basics", new[] { "location_Id" });
            DropIndex("dbo.Awards", new[] { "ResumeObject_Id" });
            DropTable("dbo.Works");
            DropTable("dbo.Volunteers");
            DropTable("dbo.Skills");
            DropTable("dbo.ResumeObjects");
            DropTable("dbo.References");
            DropTable("dbo.Publications");
            DropTable("dbo.Profiles");
            DropTable("dbo.Languages");
            DropTable("dbo.Interests");
            DropTable("dbo.Educations");
            DropTable("dbo.Locations");
            DropTable("dbo.Basics");
            DropTable("dbo.Awards");
        }
    }
}
