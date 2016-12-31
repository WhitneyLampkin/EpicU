namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowingsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Friendships", "Requester_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Friendships", "RequesteeId", "dbo.AspNetUsers");
            DropIndex("dbo.Friendships", new[] { "RequesteeId" });
            DropIndex("dbo.Friendships", new[] { "Requester_Id" });
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                        FriendshipId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Friends = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.FollowerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId)
                .ForeignKey("dbo.AspNetUsers", t => t.FolloweeId)
                .Index(t => t.FollowerId)
                .Index(t => t.FolloweeId);
            
            DropTable("dbo.Friendships");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        ResquesterId = c.String(nullable: false, maxLength: 128),
                        RequesteeId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Requester_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ResquesterId, t.RequesteeId });
            
            DropForeignKey("dbo.Followings", "FolloweeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollowerId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "FolloweeId" });
            DropIndex("dbo.Followings", new[] { "FollowerId" });
            DropTable("dbo.Followings");
            CreateIndex("dbo.Friendships", "Requester_Id");
            CreateIndex("dbo.Friendships", "RequesteeId");
            AddForeignKey("dbo.Friendships", "RequesteeId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Friendships", "Requester_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
