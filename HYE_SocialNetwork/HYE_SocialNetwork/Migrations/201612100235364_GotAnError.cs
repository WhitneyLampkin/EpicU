namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GotAnError : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Friendships");
            AddColumn("dbo.Friendships", "ResquesteeId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Friendships", new[] { "ResquesteeId", "RequesteeId" });
            DropColumn("dbo.Friendships", "ResquesterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Friendships", "ResquesterId", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Friendships");
            DropColumn("dbo.Friendships", "ResquesteeId");
            AddPrimaryKey("dbo.Friendships", new[] { "ResquesterId", "RequesteeId" });
        }
    }
}
