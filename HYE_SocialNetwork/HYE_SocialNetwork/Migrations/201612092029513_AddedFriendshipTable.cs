namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFriendshipTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        ResquesterId = c.String(nullable: false, maxLength: 128),
                        RequesteeId = c.String(nullable: false, maxLength: 128),
                        Requester_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ResquesterId, t.RequesteeId })
                .ForeignKey("dbo.AspNetUsers", t => t.Requester_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.RequesteeId)
                .Index(t => t.RequesteeId)
                .Index(t => t.Requester_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "RequesteeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Friendships", "Requester_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Friendships", new[] { "Requester_Id" });
            DropIndex("dbo.Friendships", new[] { "RequesteeId" });
            DropTable("dbo.Friendships");
        }
    }
}
