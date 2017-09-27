namespace EducationEfMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmajors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        MajorId = c.Int(),
                        Sat = c.Int(nullable: false),
                        Gpa = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Majors", t => t.MajorId)
                .Index(t => t.MajorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "MajorId", "dbo.Majors");
            DropIndex("dbo.Students", new[] { "MajorId" });
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
        }
    }
}
