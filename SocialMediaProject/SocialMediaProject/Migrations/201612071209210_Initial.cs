namespace SocialMediaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageModels",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Sent = c.DateTime(nullable: false),
                        MessageBody = c.String(),
                        SenderId = c.String(nullable: false, maxLength: 128),
                        MyProperty = c.Int(),
                        RecipientId = c.String(maxLength: 128),
                        LikeBtn = c.Boolean(),
                        TotalLikes = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.ApplicationUser", t => t.SenderId)
                .ForeignKey("dbo.ApplicationUser", t => t.RecipientId)
                .Index(t => t.SenderId)
                .Index(t => t.RecipientId);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProfileId = c.Int(nullable: false),
                        Picture = c.String(),
                        ProfilePicture = c.Binary(),
                        FirstName = c.String(),
                        MiddleInitial = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        ScenarioModels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ScenarioModels", t => t.ScenarioModels_Id)
                .Index(t => t.ScenarioModels_Id);
            
            CreateTable(
                "dbo.FriendshipModels",
                c => new
                    {
                        FriendshipId = c.Int(nullable: false, identity: true),
                        FriendshipStatus = c.Int(),
                        CurrentUserOnline = c.Boolean(nullable: false),
                        RecipientOnline = c.Boolean(nullable: false),
                        CurrentUserId = c.String(nullable: false, maxLength: 128),
                        RecipientId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FriendshipId)
                .ForeignKey("dbo.ApplicationUser", t => t.CurrentUserId)
                .ForeignKey("dbo.ApplicationUser", t => t.RecipientId)
                .Index(t => t.CurrentUserId)
                .Index(t => t.RecipientId);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.ScenarioModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Difficulty = c.Int(),
                        Backstory = c.String(),
                        Date = c.DateTime(nullable: false),
                        WrongAnsA = c.String(),
                        WrongAnsB = c.String(),
                        CorrectAns = c.String(),
                        SourceLink = c.String(),
                        Image = c.Binary(),
                        BackupImage = c.String(),
                        Result = c.String(),
                        TotalAttemps = c.Int(nullable: false),
                        TotalWrongAns = c.Int(nullable: false),
                        TotalCorrectAns = c.Int(nullable: false),
                        Favorite = c.Boolean(nullable: false),
                        TotalFavors = c.Int(nullable: false),
                        Goal = c.String(),
                        MyProperty = c.Int(),
                        Timer = c.DateTime(),
                        FastestTime = c.DateTime(),
                        FastestUserId = c.String(maxLength: 128),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.FastestUserId)
                .Index(t => t.FastestUserId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CommentModelsApplicationUser",
                c => new
                    {
                        CommentModels_MessageId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CommentModels_MessageId, t.ApplicationUser_Id })
                .ForeignKey("dbo.MessageModels", t => t.CommentModels_MessageId, cascadeDelete: true)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id, cascadeDelete: true)
                .Index(t => t.CommentModels_MessageId)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.ScenarioModels", "FastestUserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.ApplicationUser", "ScenarioModels_Id", "dbo.ScenarioModels");
            DropForeignKey("dbo.MessageModels", "RecipientId", "dbo.ApplicationUser");
            DropForeignKey("dbo.MessageModels", "SenderId", "dbo.ApplicationUser");
            DropForeignKey("dbo.CommentModelsApplicationUser", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.CommentModelsApplicationUser", "CommentModels_MessageId", "dbo.MessageModels");
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.FriendshipModels", "RecipientId", "dbo.ApplicationUser");
            DropForeignKey("dbo.FriendshipModels", "CurrentUserId", "dbo.ApplicationUser");
            DropIndex("dbo.CommentModelsApplicationUser", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.CommentModelsApplicationUser", new[] { "CommentModels_MessageId" });
            DropIndex("dbo.ScenarioModels", new[] { "FastestUserId" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.FriendshipModels", new[] { "RecipientId" });
            DropIndex("dbo.FriendshipModels", new[] { "CurrentUserId" });
            DropIndex("dbo.ApplicationUser", new[] { "ScenarioModels_Id" });
            DropIndex("dbo.MessageModels", new[] { "RecipientId" });
            DropIndex("dbo.MessageModels", new[] { "SenderId" });
            DropTable("dbo.CommentModelsApplicationUser");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.ScenarioModels");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.FriendshipModels");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.MessageModels");
        }
    }
}
