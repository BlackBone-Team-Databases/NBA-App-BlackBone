namespace TeamWorkTEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
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
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OffRtg = c.String(),
                        DeffRtg = c.String(),
                        Url = c.String(),
                        Conference_ID = c.String(maxLength: 128),
                        League_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Confers", t => t.Conference_ID)
                .ForeignKey("dbo.Leags", t => t.League_ID)
                .Index(t => t.Conference_ID)
                .Index(t => t.League_ID);
            
            CreateTable(
                "dbo.Confers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Conference = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Leags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        League = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "League_ID", "dbo.Leags");
            DropForeignKey("dbo.Teams", "Conference_ID", "dbo.Confers");
            DropForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players");
            DropIndex("dbo.Teams", new[] { "League_ID" });
            DropIndex("dbo.Teams", new[] { "Conference_ID" });
            DropIndex("dbo.PlayerStatistics", new[] { "Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropTable("dbo.Leags");
            DropTable("dbo.Confers");
            DropTable("dbo.Teams");
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Players");
        }
    }
}
