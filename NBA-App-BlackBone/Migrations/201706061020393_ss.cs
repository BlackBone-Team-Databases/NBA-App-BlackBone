namespace NbaBlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players");
            DropForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues");
            DropForeignKey("dbo.Teams", "Devision_Id", "dbo.Devisions");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.PlayerStatistics", new[] { "Id" });
            DropIndex("dbo.Teams", new[] { "Devision_Id" });
            DropIndex("dbo.Devisions", new[] { "Conference_Id" });
            DropIndex("dbo.Conferences", new[] { "League_Id" });
            DropColumn("dbo.Players", "Team_Id");
            DropColumn("dbo.Teams", "Devision_Id");
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Devisions");
            DropTable("dbo.Conferences");
            DropTable("dbo.Leagues");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LeagueEnum = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ConferenceEnum = c.Int(nullable: false),
                        Url = c.String(),
                        League_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DevisionEnum = c.Int(nullable: false),
                        Url = c.String(),
                        Conference_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teams", "Devision_Id", c => c.Int());
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            CreateIndex("dbo.Conferences", "League_Id");
            CreateIndex("dbo.Devisions", "Conference_Id");
            CreateIndex("dbo.Teams", "Devision_Id");
            CreateIndex("dbo.PlayerStatistics", "Id");
            CreateIndex("dbo.Players", "Team_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Teams", "Devision_Id", "dbo.Devisions", "Id");
            AddForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues", "Id");
            AddForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences", "Id");
            AddForeignKey("dbo.PlayerStatistics", "Id", "dbo.Players", "Id");
        }
    }
}
