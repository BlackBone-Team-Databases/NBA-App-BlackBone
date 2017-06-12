namespace NbaBlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Players", "Id", name: "Id");
            CreateIndex("dbo.Devisions", "Id", name: "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Devisions", "Id");
            DropIndex("dbo.Players", "Id");
        }
    }
}
