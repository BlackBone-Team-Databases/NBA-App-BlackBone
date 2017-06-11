namespace NbaBlackBone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedIdTypeLeagueConference : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences");
            DropForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues");
            DropIndex("dbo.Devisions", new[] { "Conference_Id" });
            DropIndex("dbo.Conferences", new[] { "League_Id" });
            DropPrimaryKey("dbo.Conferences");
            DropPrimaryKey("dbo.Leagues");
            AlterColumn("dbo.Devisions", "Conference_Id", c => c.Int());
            AlterColumn("dbo.Conferences", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Conferences", "League_Id", c => c.Int());
            AlterColumn("dbo.Leagues", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Conferences", "Id");
            AddPrimaryKey("dbo.Leagues", "Id");
            CreateIndex("dbo.Devisions", "Conference_Id");
            CreateIndex("dbo.Conferences", "League_Id");
            AddForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences", "Id");
            AddForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues");
            DropForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences");
            DropIndex("dbo.Conferences", new[] { "League_Id" });
            DropIndex("dbo.Devisions", new[] { "Conference_Id" });
            DropPrimaryKey("dbo.Leagues");
            DropPrimaryKey("dbo.Conferences");
            AlterColumn("dbo.Leagues", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Conferences", "League_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Conferences", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Devisions", "Conference_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Leagues", "Id");
            AddPrimaryKey("dbo.Conferences", "Id");
            CreateIndex("dbo.Conferences", "League_Id");
            CreateIndex("dbo.Devisions", "Conference_Id");
            AddForeignKey("dbo.Conferences", "League_Id", "dbo.Leagues", "Id");
            AddForeignKey("dbo.Devisions", "Conference_Id", "dbo.Conferences", "Id");
        }
    }
}
