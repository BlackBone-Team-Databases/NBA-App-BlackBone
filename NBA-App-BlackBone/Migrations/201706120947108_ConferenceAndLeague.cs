namespace NbaBlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConferenceAndLeague : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Position = c.Single(nullable: false),
                        Url = c.String(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.PlayerStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Minutes = c.Single(nullable: false),
                        SimplePossFor = c.Int(nullable: false),
                        SimplePointsFor = c.Int(nullable: false),
                        SimpleORebFor = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Minutes = c.Single(nullable: false),
                        OffRtg = c.Single(nullable: false),
                        DeffRtg = c.Single(nullable: false),
                        OverallRtg = c.Single(nullable: false),
                        Url = c.String(),
                        Devision_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Devisions", t => t.Devision_Id)
                .Index(t => t.Devision_Id);
            
            CreateTable(
                "dbo.Devisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DevisionEnum = c.Int(nullable: false),
                        Url = c.String(),
                        Conference_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conferences", t => t.Conference_Id)
                .Index(t => t.Conference_Id);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConferenceEnum = c.Int(nullable: false),
                        Url = c.String(),
                        League_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leagues", t => t.League_Id)
                .Index(t => t.Id, name: "Id")
                .Index(t => t.League_Id);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeagueEnum = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, name: "Id");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Devision_Id", "dbo.Devisions");
            DropForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues");
            DropForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players");
            DropIndex("dbo.Leagues", "Id");
            DropIndex("dbo.Conferences", new[] { "League_Id" });
            DropIndex("dbo.Conferences", "Id");
            DropIndex("dbo.Devisions", new[] { "Conference_Id" });
            DropIndex("dbo.Teams", new[] { "Devision_Id" });
            DropIndex("dbo.PlayerStatistics", new[] { "Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropTable("dbo.Leagues");
            DropTable("dbo.Conferences");
            DropTable("dbo.Devisions");
            DropTable("dbo.Teams");
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Players");
        }
    }
}
