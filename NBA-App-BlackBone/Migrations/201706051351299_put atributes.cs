namespace NBABlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class putatributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Confs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Conference = c.Int(nullable: false),
                        Url = c.String(),
                        League_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leags", t => t.League_Id)
                .Index(t => t.League_Id);
            
            CreateTable(
                "dbo.Divs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Devision = c.Int(nullable: false),
                        Url = c.String(),
                        Conference_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Confs", t => t.Conference_Id)
                .Index(t => t.Conference_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Minutes = c.Int(nullable: false),
                        OffRtg = c.String(),
                        DeffRtg = c.String(),
                        OverallRtg = c.Int(nullable: false),
                        Url = c.String(),
                        Devision_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Divs", t => t.Devision_Id)
                .Index(t => t.Devision_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        PlayerTrueName = c.String(),
                        Position = c.String(),
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
                        PPG = c.Int(nullable: false),
                        PRG = c.Int(nullable: false),
                        Blocks = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Leags",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        League = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Confs", "League_Id", "dbo.Leags");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players");
            DropForeignKey("dbo.Teams", "Devision_Id", "dbo.Divs");
            DropForeignKey("dbo.Divs", "Conference_Id", "dbo.Confs");
            DropIndex("dbo.PlayerStatistics", new[] { "Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Teams", new[] { "Devision_Id" });
            DropIndex("dbo.Divs", new[] { "Conference_Id" });
            DropIndex("dbo.Confs", new[] { "League_Id" });
            DropTable("dbo.Leags");
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Divs");
            DropTable("dbo.Confs");
        }
    }
}
