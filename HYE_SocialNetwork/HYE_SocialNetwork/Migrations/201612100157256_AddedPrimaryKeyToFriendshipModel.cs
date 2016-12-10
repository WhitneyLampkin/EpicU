namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrimaryKeyToFriendshipModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Friendships", "Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Friendships", "Id");
        }
    }
}
