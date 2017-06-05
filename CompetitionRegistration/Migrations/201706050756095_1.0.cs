namespace CompetitionRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Category = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Competitor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitors", t => t.Competitor_Id)
                .Index(t => t.Competitor_Id);
            
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Sex = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Moderators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        Specialization = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competitions", "Competitor_Id", "dbo.Competitors");
            DropIndex("dbo.Competitions", new[] { "Competitor_Id" });
            DropTable("dbo.Moderators");
            DropTable("dbo.Competitors");
            DropTable("dbo.Competitions");
        }
    }
}
