namespace NBABlackBone.MigrationsPostgre
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Schedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Date_Day = c.Int(nullable: false),
                        Date_Month = c.Int(nullable: false),
                        Date_Year = c.Int(nullable: false),
                        arena = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TeamAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        score = c.Int(nullable: false),
                        HOR = c.Int(nullable: false),
                        Schedule_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.Schedules", t => t.Schedule_Id)
                .Index(t => t.Schedule_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamAttendances", "Schedule_Id", "public.Schedules");
            DropIndex("dbo.TeamAttendances", new[] { "Schedule_Id" });
            DropTable("dbo.TeamAttendances");
            DropTable("public.Schedules");
        }
    }
}
