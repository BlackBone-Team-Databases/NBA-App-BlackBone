namespace NbaBlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamID : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Teams", "Id", name: "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Teams", "Id");
        }
    }
}
