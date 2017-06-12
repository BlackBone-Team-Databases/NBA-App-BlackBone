namespace NBABlackBone.MigrationsPostgre
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WORK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date_Day = c.Int(nullable: false),
                        Date_Month = c.Int(nullable: false),
                        Date_Year = c.Int(nullable: false),
                        Arena = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, name: "Id");
            
            CreateTable(
                "dbo.TeamAttendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(name: "Team Name"),
                        Score = c.Int(nullable: false),
                        HomeorAway = c.Int(name: "Home or Away", nullable: false),
                        Schedule_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Schedules", t => t.Schedule_Id)
                .Index(t => t.Id, name: "Id")
                .Index(t => t.Schedule_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamAttendances", "Schedule_Id", "public.Schedules");
            DropIndex("dbo.TeamAttendances", new[] { "Schedule_Id" });
            DropIndex("dbo.TeamAttendances", "Id");
            DropIndex("public.Schedules", "Id");
            DropTable("dbo.TeamAttendances");
            DropTable("public.Schedules");
        }
    }
}
