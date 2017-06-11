namespace NBABlackBone.MigrationsSQLite
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConferenceEnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Minutes = c.Double(nullable: false, storeType: "real"),
                        OffRtg = c.Double(nullable: false, storeType: "real"),
                        DeffRtg = c.Double(nullable: false, storeType: "real"),
                        OverallRtg = c.Double(nullable: false, storeType: "real"),
                        Url = c.String(maxLength: 2147483647),
                        Devision_Id = c.Int(),
                        Standing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Devisions", t => t.Devision_Id)
                .ForeignKey("dbo.Standings", t => t.Standing_Id)
                .Index(t => t.Devision_Id)
                .Index(t => t.Standing_Id);
            
            CreateTable(
                "dbo.Devisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DevisionEnum = c.Int(nullable: false),
                        Url = c.String(maxLength: 2147483647),
                        Conference_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conferences", t => t.Conference_Id)
                .Index(t => t.Conference_Id);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ConferenceEnum = c.Int(nullable: false),
                        Url = c.String(maxLength: 2147483647),
                        League_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leagues", t => t.League_Id)
                .Index(t => t.League_Id);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LeagueEnum = c.Int(nullable: false),
                        Url = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Position = c.Double(nullable: false, storeType: "real"),
                        Url = c.String(maxLength: 2147483647),
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
                        Minutes = c.Double(nullable: false, storeType: "real"),
                        SimplePossFor = c.Int(nullable: false),
                        SimplePointsFor = c.Int(nullable: false),
                        SimpleORebFor = c.Int(nullable: false),
                        Url = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Standing_Id", "dbo.Standings");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players");
            DropForeignKey("dbo.Teams", "Devision_Id", "dbo.Devisions");
            DropForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues");
            DropForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences");
            DropIndex("dbo.PlayerStatistics", new[] { "Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Conferences", new[] { "League_Id" });
            DropIndex("dbo.Devisions", new[] { "Conference_Id" });
            DropIndex("dbo.Teams", new[] { "Standing_Id" });
            DropIndex("dbo.Teams", new[] { "Devision_Id" });
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Players");
            DropTable("dbo.Leagues");
            DropTable("dbo.Conferences");
            DropTable("dbo.Devisions");
            DropTable("dbo.Teams");
            DropTable("dbo.Standings");
        }
    }
}
